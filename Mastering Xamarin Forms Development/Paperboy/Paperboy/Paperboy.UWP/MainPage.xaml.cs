// If Prism is to be used
//using Prism;
//using Prism.Ioc;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Paperboy.UWP {
  public sealed partial class MainPage {
    public MainPage() {
      this.InitializeComponent();

      LoadApplication(new Paperboy.App());

      // If Prism is to be used
      //LoadApplication(new Paperboy.App(new UwpInitializer()));
    }
  }

  // If Prism is to be used
  //public class UwpInitializer : IPlatformInitializer {
  //  public void RegisterTypes(IContainerRegistry containerRegistry) {
  //    // Register any platform specific implementations
  //  }
  //}
}
