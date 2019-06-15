using Newtonsoft.Json;
using Paperboy.Models;
using Paperboy.News;
using Paperboy.News.Trending;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Paperboy.Helpers {
  public static class NewsHelper {
    public static async Task<List<NewsInformation>> GetByCategoryAsync(NewsCategoryType category) {
      List<NewsInformation> results = new List<NewsInformation>();

      //string searchUrl = $"https://api.cognitive.microsoft.com/bing/v5.0/news/?Category={category}";

      //var client = new HttpClient();
      //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Common.CoreConstants.BingNewsSearchApiKey);

      //var uri = new Uri(searchUrl);
      //var result = await client.GetStringAsync(uri);
      //var newsResult = JsonConvert.DeserializeObject<NewsResult>(result);

      //results = (from item in newsResult.value
      //           select new NewsInformation() {
      //             Title = item.name,
      //             Description = item.description,
      //             //CreatedDate = item.datePublished,
      //             CreatedDate = item.datePublished.ToString(CultureInfo.InstalledUICulture),
      //             ImageUrl = item.image?.thumbnail?.contentUrl,

      //           }).ToList();

      return results.Where(w => !string.IsNullOrEmpty(w.ImageUrl)).Take(10).ToList();
    }

    //public static async Task<List<NewsInformation>> GetAsync(string searchQuery) {
    //  List<NewsInformation> results = new List<NewsInformation>();

    //  string searchUrl = $"https://api.cognitive.microsoft.com/bing/v5.0/news/search?q={searchQuery}&count=10&offset=0&mkt=en-us&safeSearch=Moderate";

    //  var client = new HttpClient();
    //  client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Common.CoreConstants.BingNewsSearchApiKey);

    //  var uri = new Uri(searchUrl);
    //  var result = await client.GetStringAsync(uri);
    //  var newsResult = JsonConvert.DeserializeObject<NewsResult>(result);

    //  results = (from item in newsResult.value
    //             select new NewsInformation() {
    //               Title = item.name,
    //               Description = item.description,
    //               CreatedDate = item.datePublished,
    //               ImageUrl = item.image?.thumbnail?.contentUrl,

    //             }).ToList();

    //  return results.Where(w => !string.IsNullOrEmpty(w.ImageUrl)).Take(10).ToList();
    //}

    public async static Task<List<NewsInformation>> GetTrendingAsync() {
      List<NewsInformation> results = new List<NewsInformation>();

      // Bing News Search
      //string searchUrl = Common.CoreConstants.BingNewsUrl;

      // News
      string searchUrl = Common.CoreConstants.NewsApiUrl;

      var client = new HttpClient();

      // For Bing News Search
      //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Common.CoreConstants.BingNewsSearchApiKey);
      //var uri = new Uri(searchUrl);

      // For NewsApi News Search
      var parameters = $"top-headlines?country=se&apiKey={Common.CoreConstants.NewsApiSearchApiKey}";
      var uri = new Uri(searchUrl + parameters);

      var result = await client.GetStringAsync(uri);

      // For Bing News Search
      //var newsResult = JsonConvert.DeserializeObject<TrendingNewsResult>(result);

      // For NewsApi News Search
      var newsResult = JsonConvert.DeserializeObject<NewsApiNews>(result);

      // For Bing News Search
      //results = (from item in newsResult.value
      //           select new NewsInformation() {
      //             Title = item.name,
      //             Description = item.query.text,
      //             CreatedDate = DateTime.Now,
      //             ImageUrl = item.image.url,
      //           }).ToList();

      // For NewsApi News Search
      results = (from item in newsResult.Articles
                 select new NewsInformation() {
                   Title = item.Title,
                   Description = item.Description,
                   CreatedDate = item.PublishedAt.DateTime.ToString(CultureInfo.InstalledUICulture), //DateTime.Now.ToShortDateString(), // item.PublishedAt.UtcDateTime,
                   ImageUrl = item.UrlToImage?.AbsoluteUri,
                 }).ToList();

      return results.Where(w => !string.IsNullOrEmpty(w.ImageUrl)).Take(30).ToList();

    }
  }
}
