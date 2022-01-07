using Foundation;
using System;
using System.Text;
using UIKit;
using Xam.Plugin.Mixpanel.iOS;

namespace ExampleProject
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Mixpanel version: {Mixpanel.LibVersionStatic}");
            var mixpanel = Mixpanel.SharedInstanceWithToken("YOUR_TOKEN");

            // Adding this will allow us to see Mixpanel is trying to function even though it has an invalid token. 
            mixpanel.EnableLogging = true;
            mixpanel.Track("This Event Happened");

            // This exists for Android but there does not seem to be a similar method call for iOS.
            /*
            stringBuilder.AppendLine("Device info:");
            foreach (var deviceInfo in mixpanel.DeviceInfo)
            {
                stringBuilder.AppendLine($" - {deviceInfo.Key}: {deviceInfo.Value}");
            }
            */


            MainTextView.Text = stringBuilder.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
