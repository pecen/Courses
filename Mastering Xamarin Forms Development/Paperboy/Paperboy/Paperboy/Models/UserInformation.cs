using Paperboy.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Models
{
  public class UserInformation : BindableBase {
    private string _displayName;

    public string DisplayName {
      get { return _displayName; }
      set { SetProperty(ref _displayName, value); }
    }

    private string _bioContent;

    public string BioContent {
      get { return _bioContent; }
      set { SetProperty(ref _bioContent, value); }
    }

    private string _profileImageUrl;

    public string ProfileImageUrl {
      get { return _profileImageUrl; }
      set { SetProperty(ref _profileImageUrl, value); }
    }
  }
}
