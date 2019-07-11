using Paperboy.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Models
{
  public class FavoriteInformation : BindableBase {
    private int _id;
    public int Id {
      get { return _id; }
      set { SetProperty(ref _id, value); }
    }

    private string _title;
    public string Title {
      get { return _title; }
      set { SetProperty(ref _title, value); }
    }

    private string _categoryTitle;
    public string CategoryTitle {
      get { return _categoryTitle; }
      set { SetProperty(ref _categoryTitle, value); }
    }

    private string _description;
    public string Description {
      get { return _description; }
      set { SetProperty(ref _description, value); }
    }

    private string _imageUrl;
    public string ImageUrl {
      get { return _imageUrl; }
      set { SetProperty(ref _imageUrl, value); }
    }

    // When using Bing News Search
    //private DateTime _articleDate;
    //public DateTime ArticleDate {
    //  get { return _articleDate; }
    //  set { SetProperty(ref _articleDate, value); }
    //}

    private string _articleDate;
    public string ArticleDate {
      get { return _articleDate; }
      set { SetProperty(ref _articleDate, value); }
    }

  }
}
