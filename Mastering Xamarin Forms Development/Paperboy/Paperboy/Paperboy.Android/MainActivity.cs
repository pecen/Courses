using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

// If Prism is to be used
//using Prism;
//using Prism.Ioc;

namespace Paperboy.Droid {
  // Changed the MainLauncher setting below to false bcos we don't want this activity
  // to be the start activity, i.e. we are using a splash screen. 
  [Activity(Label = "Paperboy", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {
    protected override void OnCreate(Bundle savedInstanceState) {
      TabLayoutResource = Resource.Layout.Tabbar;
      ToolbarResource = Resource.Layout.Toolbar;

      base.OnCreate(savedInstanceState);

      global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
      LoadApplication(new App());

      // If Prism is to be used
      //LoadApplication(new App(new AndroidInitializer()));
    }
  }

  // If Prism is to be used
  //public class AndroidInitializer : IPlatformInitializer {
  //  public void RegisterTypes(IContainerRegistry containerRegistry) {
  //    // Register any platform specific implementations
  //  }
  //}
}