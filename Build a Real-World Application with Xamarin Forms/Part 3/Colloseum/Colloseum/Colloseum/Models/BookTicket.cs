using Colloseum.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colloseum.Models
{
  public class BookTicket {
    [JsonProperty("MovieName")]
    public string MovieName { get; set; }

    [JsonProperty("CustomerName")]
    public string CustomerName { get; set; }

    [JsonProperty("BookingDate")]
    public string BookingDate { get; set; }

    [JsonProperty("Qty")]
    [JsonConverter(typeof(ParseStringConverter))]
    public long Qty { get; set; }

    [JsonProperty("Phone")]
    public string Phone { get; set; }

    [JsonProperty("Email")]
    public string Email { get; set; }

    [JsonProperty("TotalPayment")]
    [JsonConverter(typeof(ParseStringConverter))]
    public long TotalPayment { get; set; }
  }
}
