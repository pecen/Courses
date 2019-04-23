using Colloseum.Models;
using Colloseum.UI.Mobile.Services;
using Colloseum.UI.Mobile.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Colloseum.UI.Mobile.ViewModels
{
	public class NowPlayingMoviesViewModel : ViewModelBase
	{
    public ObservableCollection<NowPlayingMovie> NowPlayingMovies { get; set; }

    public NowPlayingMoviesViewModel(INavigationService navigationService) : base(navigationService) {
      Initialize();
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
