﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;

// If Prism is to be used
//using Prism;
//using Prism.Ioc;

using UIKit;

namespace Paperboy.iOS {
  // The UIApplicationDelegate for the application. This class is responsible for launching the 
  // User Interface of the application, as well as listening (and optionally responding) to 
  // application events from iOS.
  [Register("AppDelegate")]
  public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate {
    //
    // This method is invoked when the application has loaded and is ready to run. In this 
    // method you should instantiate the window, load the UI into it and then make the window
    // visible.
    //
    // You have 17 seconds to return from this method, or iOS will terminate your application.
    //
    public override bool FinishedLaunching(UIApplication app, NSDictionary options) {
      global::Xamarin.Forms.Forms.Init();

      UIColor accentColor = UIColor.FromRGB(0, 89, 178);

      UISlider.Appearance.TintColor = accentColor;
      UISlider.Appearance.ThumbTintColor = accentColor;

      UITabBar.Appearance.TintColor = accentColor;
      UITabBar.Appearance.SelectedImageTintColor = accentColor;

      UINavigationBar.Appearance.BarTintColor = accentColor;
      UINavigationBar.Appearance.TintColor = UIColor.White;
      UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes { TextColor = UIColor.White });

      LoadApplication(new App());

      // If Prism is to be used
      //LoadApplication(new App(new iOSInitializer()));

      // This is something unnecessary, and only for test
      //var x = typeof(Xamarin.Forms.Themes.DarkThemeResources);
      //x = typeof(Xamarin.Forms.Themes.LightThemeResources);
      //x = typeof(Xamarin.Forms.Themes.iOS.UnderlineEffect);

      return base.FinishedLaunching(app, options);
    }
  }

  // If Prism is to be used
  //public class iOSInitializer : IPlatformInitializer {
  //  public void RegisterTypes(IContainerRegistry containerRegistry) {
  //    // Register any platform specific implementations
  //  }
  //}
}
