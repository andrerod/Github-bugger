using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace githubbugger
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate () { }

		public override void FinishedLaunching (NSObject notification)
		{
			// Construct menu that will be displayed when tray icon is clicked
			var notifyMenu = new NSMenu();
			var exitMenuItem = new NSMenuItem("Quit My Application", 
			                                  (a,b) => { System.Environment.Exit(0); }); // Just add 'Quit' command
			notifyMenu.AddItem(exitMenuItem);

			// Display tray icon in upper-right-hand corner of the screen
			var sItem = NSStatusBar.SystemStatusBar.CreateStatusItem(30);
			sItem.Menu = notifyMenu;
			sItem.Image = NSImage.FromStream(System.IO.File.OpenRead(
				NSBundle.MainBundle.ResourcePath + @"/github-bugger.png"));
			sItem.HighlightMode = true;
		}
	}
}