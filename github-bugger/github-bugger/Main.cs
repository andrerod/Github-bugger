using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace githubbugger
{
	class MainClass
	{
		static void Main (string[] args)
		{
			NSMenu notifyMenu = new NSMenu("Hello world");

			NSStatusItem sItem = NSStatusBar.SystemStatusBar.CreateStatusItem(30);
			sItem.Menu = notifyMenu;
			sItem.Image = NSImage.FromStream(System.IO.File.OpenRead(NSBundle.MainBundle.ResourcePath + @"/notify-icon.icns"));
			sItem.HighlightMode = true;
			/*
			NSApplication.Init ();
			NSApplication.Main (args);
			*/
		}
	}
}	

