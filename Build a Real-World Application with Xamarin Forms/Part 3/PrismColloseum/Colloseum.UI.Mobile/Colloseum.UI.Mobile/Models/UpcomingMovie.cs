using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colloseum.Models
{
  public class UpcomingMovie {
    [JsonProperty("MovieId")]
    public long MovieId { get; set; }

    [JsonProperty("MovieName")]
    public string MovieName { get; set; }

    [JsonProperty("Cast")]
    public string Cast { get; set; }

    [JsonProperty("Director")]
    public string Director { get; set; }

    [JsonProperty("Description")]
    public string Description { get; set; }

    [JsonProperty("Language")]
    public string Language { get; set; }

    [JsonProperty("ReleaseDate")]
    public DateTimeOffset ReleaseDate { get; set; }

    [JsonProperty("Genre")]
    public string Genre { get; set; }

    [JsonProperty("TrailorLink")]
    public Uri TrailorLink { get; set; }

    [JsonProperty("Logo")]
    public string Logo { get; set; }

    [JsonProperty("LogoFile")]
    public object LogoFile { get; set; }
  }
}
