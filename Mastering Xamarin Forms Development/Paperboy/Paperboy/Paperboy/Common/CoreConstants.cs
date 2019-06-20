﻿using System;
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

    internal static string EventRegistrySearchApiKey {
      get { return "9cd44ac7-802b-4df5-a7fb-07bb6915ae0f"; }
    }

    internal static string NewsRiverSearchApiKey {
      get { return "sBBqsGXiYgF0Db5OV5tAwwE7BWjnfKdXEqK592hUtXJe2TsWX5ZW6PknDq86zSJAn2pHZrSf1gT2PUujH1YaQA"; }
    }

    internal static string BingNewsUrl {
      get { return "https://api.cognitive.microsoft.com/bing/v7.0/news/trendingtopics/"; }
    }

    internal static string NewsApiUrl {
      get { return "https://newsapi.org/v2/"; }
    }

    internal static string EventRegistryUrl {
      get { return "http://eventregistry.org/api/v1/"; }
    }

    internal static string NewsRiverUrl {
      get { return "https://api.newsriver.io/v2/search/"; }
    }
  }
}
