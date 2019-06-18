using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paperboy.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TechnologyPage : ContentPage
	{
		public TechnologyPage ()
		{
			InitializeComponent ();
		}

    protected override void OnAppearing() {
      //LoadNewsAsync();
      BindingContext = App.ViewModel;

      base.OnAppearing();
    }

    private void OnItemTapped(object sender, ItemTappedEventArgs e) {

    }

    //private async void LoadNewsAsync() {
    //  newsListView.IsRefreshing = true;

    //  var news = await Helpers.NewsHelper.GetByCategoryAsync(News.NewsCategoryType.ScienceAndTechnology);

    //  this.BindingContext = news;

    //  newsListView.IsRefreshing = false;
    //}
  }
}