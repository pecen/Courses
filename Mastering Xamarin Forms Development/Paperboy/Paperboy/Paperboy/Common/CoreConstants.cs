using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperboy.Common {
  internal class CoreConstants {
    internal static string BingNewsSearchApiKey {
      get { return "10325e7eab49424b8d7fac2b5c0c9384"; }
    }

    internal static string NewsApiSearchApiKey {
      get { return "5666a68a68814bf1b3614c096875f2af"; }
    }

    internal static string BingNewsUrl {
      get { return "https://api.cognitive.microsoft.com/bing/v7.0/news/trendingtopics"; }
    }

    internal static string NewsApiUrl {
      get { return "https://newsapi.org/v2/"; }
    }
  }
}
