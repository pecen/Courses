using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Colloseum.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colloseum
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NowPlayingMoviesPage : ContentPage
	{
		public NowPlayingMoviesPage ()
		{
			InitializeComponent ();
      BindingContext = new NowPlayingMoviesPageViewModel(Navigation);
		}
  }
}