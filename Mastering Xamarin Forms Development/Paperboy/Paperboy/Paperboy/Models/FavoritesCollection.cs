using Paperboy.Data;
using Paperboy.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.Models
{
  public class FavoritesCollection : ObservableCollection<FavoriteInformation> {
    public async Task<int> AddAsync(FavoriteInformation article) {

      //var favorite = new Favorite() {
      //  ArticleDate = article.ArticleDate,
      //  Description = article.Description,
      //  ImageUrl = article.ImageUrl,
      //  Title = article.Title,
      //};

      //await FavoritesManager.DefaultManager.SaveFavoriteAsync(favorite);

      //Add(article);

      int id = -1;

      await FavoritesHelper.EnsureCategoriesAsync();

      var category = await App.Database.GetCategoryAsync(article.CategoryTitle);

      if(category != null) {
        id = await App.Database.SaveItemAsync(new Favorite {
          ArticleDate = DateTime.Parse(article.ArticleDate),
          Category = category,
          CategoryId = category.Id,
          Description = article.Description,
          ImageUrl = article.ImageUrl,
          Title = article.Title
        });
        article.Id = id;
        Add(article);
      }
      return id;
    }

    public async Task<int> RemoveAsync(int id) {
      var favorite = await App.Database.GetItemAsync(id);

      id = await App.Database.DeleteItemAsync(favorite);

      return id;
    }
  }
}
