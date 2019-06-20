using Paperboy.Helpers;
using Paperboy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paperboy.Pages {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SettingsPage : ContentPage {
    //public UserInformation CurrentUser { get; set; }

    public SettingsPage() {
      InitializeComponent();
    }

    protected override void OnAppearing() {
      InitializeSettings();

      base.OnAppearing();
    }

    private void InitializeSettings() {
      BindingContext = App.ViewModel;

      articleCountSlider.Value = 10;
      categoryPicker.SelectedIndex = 1;

      var label = GeneralHelper.GetLabel();
      var extendedLabel = GeneralHelper.GetLabel("Running Paperboy on", true);
      var orientation = GeneralHelper.GetOrientation();

      App.ViewModel.PlatformLabel = label;
      App.ViewModel.ExtendedPlatformLabel = extendedLabel;
      App.ViewModel.CurrentOrientation = orientation;
    }

    private void Button_Clicked(object sender, EventArgs e) {
      App.Current.Resources["ListTextColor"] = Color.Blue;
    }
  }
}