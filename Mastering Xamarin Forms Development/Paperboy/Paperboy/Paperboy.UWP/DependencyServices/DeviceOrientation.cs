﻿using Paperboy.Interfaces;
using Paperboy.UWP.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientation))]
namespace Paperboy.UWP.DependencyServices {
  public class DeviceOrientation : IDeviceOrientation {
    public DeviceOrientation() { }

    public DeviceOrientations GetOrientation() {
      var orientation = ApplicationView.GetForCurrentView().Orientation;
      if (orientation == ApplicationViewOrientation.Landscape)
        return DeviceOrientations.Landscape;
      else
        return DeviceOrientations.Portrait;
    }
  }
}
