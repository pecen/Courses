using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Paperboy.Interfaces;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(Paperboy.iOS.DependencyServices.PlatformLabel))]
namespace Paperboy.iOS.DependencyServices {
  public class PlatformLabel : IPlatformLabel {
    public PlatformLabel() { }

    public string GetLabel() {
      return "iOS";
    }

    public string GetLabel(string additionalLabel) {
      return $"{additionalLabel} iOS";
    }

    public string GetLabel(string additionalLabel, bool addVersion) {
      string label = (addVersion) ? label = $"{additionalLabel} iOS {GetOsVersion()}" :
          $"{additionalLabel} iOS";

      return label;
    }

    private string GetOsVersion() {
      return UIDevice.CurrentDevice.SystemVersion;
    }
  }
}