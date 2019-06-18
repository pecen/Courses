using Paperboy.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Paperboy.Common.Commands
{
  public class NavigateToSettingsCommand : ICommand {
    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter) {
      return true;
    }

    public void RaiseCanExecuteChanged() {
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);

      // The old way of doing the above
      //var handler = CanExecuteChanged;
      //if (handler != null) {
      //  handler(this, EventArgs.Empty);
      //}
    }

    public void Execute(object parameter) {
      NavigateAsync();
    }

    private async void NavigateAsync() {
      await App.MainNavigation.PushAsync(new SettingsPage(), true);
    }
  }

  public class RefreshNewsCommand : ICommand {
    private bool _isBusy = false;

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter) {
      return !_isBusy;
    }

    public void RaiseCanExecuteChanged() {
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);

      // The old way of doing the above
      //var handler = CanExecuteChanged;
      //if (handler != null) {
      //  handler(this, EventArgs.Empty);
      //}
      }

      public void Execute(object parameter) {
      RefreshNewsAsync((string)parameter);
    }

    private async void RefreshNewsAsync(string newsType) {
      _isBusy = true;
      RaiseCanExecuteChanged();
      App.ViewModel.IsBusy = true;

      switch (newsType) {
        case "World":
          await App.ViewModel.RefreshWorldNewsAsync();
          break;
        case "Technology":
          await App.ViewModel.RefreshTechnologyNewsAsync();
          break;
        case "Trending":
          await App.ViewModel.RefreshTrendingNewsAsync();
          break;
      }

      _isBusy = false;
      RaiseCanExecuteChanged();
      App.ViewModel.IsBusy = false;
    }
  }

  public class NavigateToDetailCommand : ICommand {
    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter) {
      return true;
    }

    public void RaiseCanExecuteChanged() {
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);

      // The old way of doing the above
      //var handler = CanExecuteChanged;
      //if (handler != null) {
      //  handler(this, EventArgs.Empty);
      //}
    }

    public void Execute(object parameter) {
      NavigateToDetailAsync(parameter as News.NewsInformation);
    }

    private async void NavigateToDetailAsync(News.NewsInformation article) {
      await App.MainNavigation.PushAsync(new Pages.ItemDetailPage(article), true);
    }
  }
}
