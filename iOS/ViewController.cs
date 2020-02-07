using System;

using UIKit;

namespace HolaXamarin.iOS
{
    public partial class ViewController : UIViewController
    {
        

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        partial void UIButton817_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}
