﻿using Paperboy.Data;
using Paperboy.Interfaces;
using Paperboy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Paperboy {
  // If Prism is to be used
  //public partial class App {

  public partial class App : Application {
    public static MainPageViewModel ViewModel { get; set; }
    public static INavigation MainNavigation { get; set; }

    public App() {
      InitializeComponent();

      MainPage = new NavigationPage(new MainPage());
    }

    // The following comment is valid if Prism is used
    ///* 
    // * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
    // * This imposes a limitation in which the App class must have a default constructor. 
    // * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
    // */

    // The following commented out code should be used if Prism is to be used
    //public App() : this(null) { }

    //public App(IPlatformInitializer initializer) : base(initializer) { }

    //protected override async void OnInitialized() {
    //  InitializeComponent();

    //  await NavigationService.NavigateAsync("NavigationPage/MainPage");
    //}

    //protected override void RegisterTypes(IContainerRegistry containerRegistry) {

    //}

    static FavoritesDatabase database;
    public static FavoritesDatabase Database {
      get {
        if (database == null) {
          database = new FavoritesDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("Favorites.db3"));
        }
        return database;
      }
    }

    protected override void OnStart() {
      // Handle when your app starts
    }

    protected override void OnSleep() {
      // Handle when your app sleeps
    }

    protected override void OnResume() {
      // Handle when your app resumes
    }
  }
}
