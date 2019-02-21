using Colloseum.Extensions;
using Colloseum.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Colloseum.Services
{
  public class ApiServices {
    private readonly string _nowPlayingMovies = "http://colosseum.somee.com/api/NowPlayingMovies";
    private readonly string _upcomingMovies = "http://colosseum.somee.com/api/UpComingMovies";
    private readonly string _orderApi = "http://colosseum.somee.com/api/Orders";
    private readonly string _apiKey = "cd187362-b986-4dd8-8162-17e28ddd2699";

    public async Task<List<NowPlayingMovie>> GetNowPlayingMovies() {
      var client = new HttpClient();
      HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, _nowPlayingMovies);
      request.Headers.Add("ApiKey", "cd187362-b986-4dd8-8162-17e28ddd2699");
      var response = await client.SendAsync(request);
      var movies = await response.Content.ReadAsStringAsync();

      //var v = FromJson<List<NowPlayingMovie>>(movies);
      var v = new List<NowPlayingMovie>().FromJson(movies);
      return v;
    }

    public async Task<List<UpcomingMovie>> GetUpcomingMovies() {
      var client = new HttpClient();
      HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, _upcomingMovies);
      request.Headers.Add("ApiKey", "cd187362-b986-4dd8-8162-17e28ddd2699");
      var response = await client.SendAsync(request);
      var movies = await response.Content.ReadAsStringAsync();

      //var v = FromJson<List<NowPlayingMovie>>(movies);
      var v = new List<UpcomingMovie>().FromJson(movies);
      return v;
    }

    public async Task<bool> Order(BookTicket bookTicket) {
      var client = new HttpClient();
      var json = bookTicket.ToJson();
      var content = new StringContent(json, Encoding.UTF8, "application/json");
      content.Headers.Add("ApiKey", _apiKey);
      var response = await client.PostAsync(_orderApi, content);

      return response.IsSuccessStatusCode;
    }
  }
}
