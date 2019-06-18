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
      //CurrentUser = new UserInformation {
      //  DisplayName = "Scott",
      //  BioContent = "Scott has been developing Microsoft Enterprise solutions for organizations around the world for the last 28 years, and is the Senior Architect & Developer behind Liquid Daffodil.",
      //  ProfileImageUrl = "https://wintellectnow.blob.core.windows.net/public/Scott_Peterson.jpg"
      //};

      BindingContext = App.ViewModel.CurrentUser;

      //displayNameEntry.Text = "Scott";
      //bioEditor.Text = "Scott has been developing Microsoft Enterprise solutions for organizations around the world for the last 28 years, and is the Senior Architect & Developer behind Liquid Daffodil.";

      articleCountSlider.Value = 10;
      categoryPicker.SelectedIndex = 1;
    }

    private void Button_Clicked(object sender, EventArgs e) {
      App.Current.Resources["ListTextColor"] = Color.Blue;
    }
  }
}