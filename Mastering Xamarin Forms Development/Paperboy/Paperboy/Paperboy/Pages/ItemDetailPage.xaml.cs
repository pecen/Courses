using Paperboy.News;
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
	public partial class ItemDetailPage : ContentPage
	{
    public NewsInformation CurrentArticle { get; set; }

    public ItemDetailPage ()
		{
			InitializeComponent ();
		}

    public ItemDetailPage(NewsInformation currentArticle) {
      InitializeComponent();
      CurrentArticle = currentArticle;
    }

    protected override void OnAppearing() {
      BindingContext = CurrentArticle;

      base.OnAppearing();
    }
  }
}