using Paperboy.Pages;
using Paperboy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paperboy {
  public partial class MainPage : TabbedPage {
    public MainPage() {
      InitializeComponent();
    }

    protected override void OnAppearing() {
      //Plugin.Connectivity.CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
      if (App.ViewModel == null) {
        App.ViewModel = new MainPageViewModel();
        App.ViewModel.RefreshNewsAsync();
      }

      App.MainNavigation = Navigation;

      //var label = Helpers.GeneralHelper.GetLabel();

      base.OnAppearing();
    }

    private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e) {
      if (!e.IsConnected) { }
    }
  }
}
