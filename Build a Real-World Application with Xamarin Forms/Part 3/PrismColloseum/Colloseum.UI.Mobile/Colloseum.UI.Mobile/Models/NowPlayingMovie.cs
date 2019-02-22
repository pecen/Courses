using Colloseum.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colloseum.Models
{
  public class NowPlayingMovie {
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

    [JsonProperty("Duration")]
    public string Duration { get; set; }

    [JsonProperty("PlayingDate")]
    public DateTimeOffset PlayingDate { get; set; }

    [JsonProperty("ShowTime1")]
    public DateTimeOffset ShowTime1 { get; set; }

    [JsonProperty("ShowTime2")]
    public DateTimeOffset ShowTime2 { get; set; }

    [JsonProperty("ShowTime3")]
    public DateTimeOffset ShowTime3 { get; set; }

    [JsonProperty("TicketPrice")]
    [JsonConverter(typeof(ParseStringConverter))]
    public long TicketPrice { get; set; }

    [JsonProperty("Rating")]
    public double Rating { get; set; }

    [JsonProperty("RatedLevel")]
    public string RatedLevel { get; set; }

    [JsonProperty("Genre")]
    public string Genre { get; set; }

    [JsonProperty("TrailorLink")]
    public Uri TrailorLink { get; set; }

    [JsonProperty("Logo")]
    public string Logo { get; set; }

    [JsonProperty("LogoFile")]
    public object LogoFile { get; set; }

    public string CoverImage {
      get {
        return $"http://colosseum.somee.com/{Logo.Substring(1)}";
      }
    }
  }
}
