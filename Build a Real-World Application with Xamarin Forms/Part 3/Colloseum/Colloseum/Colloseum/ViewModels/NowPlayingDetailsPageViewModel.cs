using Colloseum.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Colloseum.ViewModels
{
  public class NowPlayingDetailsPageViewModel : ViewModelBase {
    public NowPlayingDetailsPageViewModel(NowPlayingMovie movie) {
      Title = "Incredibles 2";

      //Cast = npm.SelectedMovie.Cast;

      MovieName = movie.MovieName;
      ImageMovieCover = movie.Logo;
      
    }

    public string MovieName { get; set; }
    public string ImageMovieCover { get; set; }
    public string RatedLevel { get; set; }
    public int Duration { get; set; }
    public string Language { get; set; }
    public string Genre { get; set; }
    public DateTime PlayingDate { get; set; }
    public string Cast { get; set; }
    public string Description { get; set; }

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e) {

    }

  }
}
