using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Data
{
  public class Favorite {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [Ignore]
    public NewsCategory Category { get; set; }
    public int CategoryId { get; set; }

    [MaxLength(100)]
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime ArticleDate { get; set; }
  }

  public class NewsCategory {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Title { get; set; }

    [Ignore]
    public string InternalName { get; set; }
  }

  //public class Favorite {
  //  string _id;
  //  string _title;
  //  string _description;
  //  string _imageUrl;
  //  DateTime _articleDate;

  //  [JsonProperty(PropertyName = "id")]
  //  public string Id {
  //    get { return _id; }
  //    set { _id = value; }
  //  }

  //  [JsonProperty(PropertyName = "title")]
  //  public string Title {
  //    get { return _title; }
  //    set { _title = value; }
  //  }

  //  [JsonProperty(PropertyName = "description")]
  //  public string Description {
  //    get { return _description; }
  //    set { _description = value; }
  //  }

  //  [JsonProperty(PropertyName = "imageUrl")]
  //  public string ImageUrl {
  //    get { return _imageUrl; }
  //    set { _imageUrl = value; }
  //  }

  //  [JsonProperty(PropertyName = "articleDate")]
  //  public DateTime ArticleDate {
  //    get { return _articleDate; }
  //    set { _articleDate = value; }
  //  }

  //  [Version]
  //  public string Version { get; set; }
  //}
}
