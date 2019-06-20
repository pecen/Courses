using Paperboy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Helpers
{
  public static class GeneralHelper {
    public static string GetLabel() {
      return Xamarin.Forms.DependencyService.Get<IPlatformLabel>().GetLabel();
    }

    public static string GetLabel(string additionalLabel) {
      return Xamarin.Forms.DependencyService.Get<IPlatformLabel>().GetLabel(additionalLabel);
    }

    public static string GetLabel(string additionalLabel, bool addVersion) {
      return Xamarin.Forms.DependencyService.Get<IPlatformLabel>().GetLabel(additionalLabel, addVersion);
    }

    public static DeviceOrientations GetOrientation() {
      var orientation = Xamarin.Forms.DependencyService.Get<IDeviceOrientation>().GetOrientation();

      return orientation;
    }

    public static void Speak(string text) {
      Xamarin.Forms.DependencyService.Get<ITextSpeecher>().Speak(text);
    }
  }
}
