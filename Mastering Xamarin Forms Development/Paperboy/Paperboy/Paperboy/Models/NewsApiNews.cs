using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Models
{
  public partial class NewsApiNews {
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("totalResults")]
    public long TotalResults { get; set; }

    [JsonProperty("articles")]
    public List<Article> Articles { get; set; }
  }
}
