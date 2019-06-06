using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperboy.Models
{
  public partial class Source {
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
  }
}
