// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloMac
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField labelOutput { get; set; }

        [Action ("onButtonClicked:")]
        partial void onButtonClicked (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (labelOutput != null) {
                labelOutput.Dispose ();
                labelOutput = null;
            }
        }
    }
}
