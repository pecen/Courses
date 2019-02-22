using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colloseum.UI.Mobile.ViewModels {
  public class MainPageViewModel : ViewModelBase {
    private readonly INavigationService _navigationService;

    public MainPageViewModel(INavigationService navigationService)
        : base(navigationService) {
      Title = "Colloseum";

      _navigationService = navigationService;
    }
  }
}
