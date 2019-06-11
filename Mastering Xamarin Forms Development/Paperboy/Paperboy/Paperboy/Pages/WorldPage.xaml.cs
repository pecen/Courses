﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paperboy.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorldPage : ContentPage
	{
		public WorldPage ()
		{
			InitializeComponent ();
		}

    protected override void OnAppearing() {
      LoadNewsAsync();

      base.OnAppearing();
    }

    private async void LoadNewsAsync() {
      newsListView.IsRefreshing = true;

      var news = await Helpers.NewsHelper.GetByCategoryAsync(News.NewsCategoryType.World);

      this.BindingContext = news;

      newsListView.IsRefreshing = false;
    }
  }
}