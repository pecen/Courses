using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Interfaces
{
  public enum DeviceOrientations {
    Undefined,
    Landscape,
    Portrait
  }

  public interface IDeviceOrientation {
    DeviceOrientations GetOrientation();
  }
}
