using Paperboy.Interfaces;
using Paperboy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.ViewModels
{
  public class MainPageViewModel : BindableBase {
    public MainPageViewModel() {
      WorldNews = new ObservableCollection<News.NewsInformation>();
      TechnologyNews = new ObservableCollection<News.NewsInformation>();
      TrendingNews = new ObservableCollection<News.NewsInformation>();

      CurrentUser = new UserInformation {
        DisplayName = "Scott",
        BioContent = "Scott has been developing Microsoft Enterprise solutions for organizations around the world for the last 28 years, and is the Senior Architect & Developer behind Liquid Daffodil.",
        ProfileImageUrl = "https://wintellectnow.blob.core.windows.net/public/Scott_Peterson.jpg"
      };
    }

    private ObservableCollection<News.NewsInformation> _worldNews;
    public ObservableCollection<News.NewsInformation> WorldNews {
      get { return _worldNews; }
      set { SetProperty(ref _worldNews, value); }
    }

    private ObservableCollection<News.NewsInformation> _technologyNews;
    public ObservableCollection<News.NewsInformation> TechnologyNews {
      get { return _technologyNews; }
      set { SetProperty(ref _technologyNews, value); }
    }

    private ObservableCollection<News.NewsInformation> _trendingNews;
    public ObservableCollection<News.NewsInformation> TrendingNews {
      get { return _trendingNews; }
      set { SetProperty(ref _trendingNews, value); }
    }

    private UserInformation _currentUser;
    public UserInformation CurrentUser {
      get { return _currentUser; }
      set { SetProperty(ref _currentUser, value); }
    }

    private string _platformLabel;
    public string PlatformLabel {
      get { return _platformLabel; }
      set { SetProperty(ref _platformLabel, value); }
    }

    private string _extendedPlatformLabel;
    public string ExtendedPlatformLabel {
      get { return _extendedPlatformLabel; }
      set { SetProperty(ref _extendedPlatformLabel, value); }
    }

    private DeviceOrientations _currentOrientation;
    public DeviceOrientations CurrentOrientation {
      get { return this._currentOrientation; }
      set { this.SetProperty(ref this._currentOrientation, value); }
    }

    private bool _isBusy;
    public bool IsBusy {
      get { return _isBusy; }
      set { SetProperty(ref _isBusy, value); }
    }

    public async void RefreshNewsAsync() {
      IsBusy = true;

      await RefreshWorldNewsAsync();
      await RefreshTechnologyNewsAsync();
      await RefreshTrendingNewsAsync();

      IsBusy = false;
    }

    public async Task RefreshWorldNewsAsync() {
      this.WorldNews.Clear();

      var news = await Helpers.NewsHelper.GetByCategoryAsync(News.NewsCategoryType.World);

      foreach (var item in news) {
        this.WorldNews.Add(item);
      }
    }

    public async Task RefreshTechnologyNewsAsync() {
      this.TechnologyNews.Clear();

      var news = await Helpers.NewsHelper.GetByCategoryAsync(News.NewsCategoryType.ScienceAndTechnology);

      foreach (var item in news) {
        this.TechnologyNews.Add(item);
      }
    }

    public async Task RefreshTrendingNewsAsync() {
      this.TrendingNews.Clear();

      var news = await Helpers.NewsHelper.GetTrendingAsync();

      foreach (var item in news) {
        this.TrendingNews.Add(item);
      }
    }
  }
}
