﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Interfaces
{
  public interface IPlatformLabel {
    string GetLabel();
    string GetLabel(string additionalLabel);
    string GetLabel(string additionalLabel, bool addVersion);
  }
}
