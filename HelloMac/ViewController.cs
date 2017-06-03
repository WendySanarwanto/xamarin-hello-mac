using System;

using AppKit;
using Foundation;

namespace HelloMac
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            labelOutput.StringValue = "Button has not been clicked yet.";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void onButtonClicked(NSObject sender)
        {
            numberOfTimesClicked++;
            string message = string.Format("The button has been clicked {0} time{1}",
                                           numberOfTimesClicked,
                                           numberOfTimesClicked < 2 ? "" : "s");
            labelOutput.StringValue = message;
        }
    }
}
