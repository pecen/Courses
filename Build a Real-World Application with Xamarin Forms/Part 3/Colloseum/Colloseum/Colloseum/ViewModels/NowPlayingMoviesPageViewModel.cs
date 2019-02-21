using Colloseum.Models;
using Colloseum.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colloseum.ViewModels
{
  public class NowPlayingMoviesPageViewModel : ViewModelBase {
    private readonly INavigation _navigation;

    public ObservableCollection<NowPlayingMovie> NowPlayingMovies { get; set; }

    public NowPlayingMoviesPageViewModel(INavigation navigation) {
      _navigation = navigation;

      NowPlayingMovies = new ObservableCollection<NowPlayingMovie>();
      Title = "Now Playing";

      Initialize();
    }

    private NowPlayingMovie _selectedMovie;
    public NowPlayingMovie SelectedMovie {
      get { return _selectedMovie; }
      set {
        if (_selectedMovie != value) {
          _selectedMovie = value;
          HandleSelectedItem();
        }
      }
    }

    private void HandleSelectedItem() {
      _navigation.PushAsync(new NowPlayingDetailsPage(SelectedMovie));

      //Page page = new Page();
      //page.DisplayAlert("Selected Movie", $"Movie: {SelectedMovie.MovieName}  Duration: {SelectedMovie.Duration}", "OK");

      //Device.BeginInvokeOnMainThread(() => {
      //  page.DisplayAlert("Selected Movie", $"Movie: {SelectedMovie.MovieName}  Duration: {SelectedMovie.Duration}", "OK");
      //});

      // TODO: Get information from SelectedItem
    }

    private async void Initialize() {
      var apiServices = new ApiServices();

      var movies = await apiServices.GetNowPlayingMovies();

      foreach (var movie in movies) {
        NowPlayingMovies.Add(movie);
      }
    }
  }
}
