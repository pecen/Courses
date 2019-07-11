using Paperboy.Data;
using Paperboy.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.Extensions
{
  public static class ListExtensions {
    public static News.NewsInformation AsArticle(this FavoriteInformation favorite) {
      return new News.NewsInformation() {
        CreatedDate = favorite.ArticleDate.ToString(),
        Description = favorite.Description,
        ImageUrl = favorite.ImageUrl,
        Title = favorite.Title,
      };
    }

    public async static Task<FavoriteInformation> AsFavorite(this News.NewsInformation article, string categoryTitle) {
      var category = await App.Database.GetCategoryAsync(categoryTitle);

      return new FavoriteInformation() {
        ArticleDate = article.CreatedDate, // DateTime.Parse(article.CreatedDate),
        Description = article.Description,
        ImageUrl = article.ImageUrl,
        Title = article.Title,
        CategoryTitle = categoryTitle
      };
    }

    public static FavoriteInformation AsFavorite(this Favorite favorite, string categoryTitle) {
      return new FavoriteInformation() {
        ArticleDate = favorite.ArticleDate.ToString(),
        Description = favorite.Description,
        ImageUrl = favorite.ImageUrl,
        Title = favorite.Title,
        CategoryTitle = categoryTitle,

      };
    }
  }
}
