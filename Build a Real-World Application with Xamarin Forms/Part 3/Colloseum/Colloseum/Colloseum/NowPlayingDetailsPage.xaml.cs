using Colloseum.Models;
using Colloseum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colloseum
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NowPlayingDetailsPage : ContentPage
	{
    public NowPlayingDetailsPage() { }
		public NowPlayingDetailsPage (NowPlayingMovie movie)
		{
			InitializeComponent ();
      BindingContext = new NowPlayingDetailsPageViewModel(movie);
		}
	}
}