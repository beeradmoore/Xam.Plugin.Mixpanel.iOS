using System.Text;
using Xam.Plugin.Mixpanel.iOS;

namespace ExampleApp;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary? launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);
		
		var stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"Mixpanel version: {Mixpanel.LibVersionStatic}");
		var mixpanel = Mixpanel.SharedInstanceWithToken("YOUR_TOKEN", false);

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
		
		// create a UIViewController with a single UILabel
		var vc = new UIViewController ();
		vc.View!.AddSubview (new UILabel (Window!.Frame) {
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = stringBuilder.ToString(),
			AutoresizingMask = UIViewAutoresizing.All,
		});
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}
