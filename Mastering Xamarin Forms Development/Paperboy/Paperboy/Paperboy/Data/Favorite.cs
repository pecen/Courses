using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;

namespace Paperboy.Data
{
  // The following commented out code was used before Azure storage
  // and synchronization was implemented
  //public class Favorite {
  //  [PrimaryKey, AutoIncrement]
  //  public int Id { get; set; }

  //  [Ignore]
  //  public NewsCategory Category { get; set; }
  //  public int CategoryId { get; set; }

  //  [MaxLength(100)]
  //  public string Title { get; set; }
  //  public string Description { get; set; }
  //  public string ImageUrl { get; set; }
  //  public DateTime ArticleDate { get; set; }
  //}

  //public class NewsCategory {
  //  [PrimaryKey, AutoIncrement]
  //  public int Id { get; set; }
  //  public string Title { get; set; }

  //  [Ignore]
  //  public string InternalName { get; set; }
  //}

  public class Favorite {
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    [JsonProperty(PropertyName = "imageUrl")]
    public string ImageUrl { get; set; }

    [JsonProperty(PropertyName = "articleDate")]
    public DateTime ArticleDate { get; set; }

    [Version]
    public string Version { get; set; }
  }
}
