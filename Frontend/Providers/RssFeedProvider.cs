using Frontend.Models;
using Frontend.NeededForSerialization;
using Frontend.Providers.Interfaces;
using Microsoft.SyndicationFeed;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace Frontend.Providers
{
    public class RssFeedProvider : IRssFeedProvider
    {
        private readonly HttpClient _httpClient;

        public RssFeedProvider()
        {
            _httpClient = new HttpClient();
        }

        public HomeViewModel GetAllRssFeeds()
        {
            var response = _httpClient.GetAsync("https://localhost:44329/NewsSiteApi/RssFeed/All");
            return new HomeViewModel
            {
                RssFeedsViewModel = new RssFeedsViewModel
                {
                    RssFeeds = JsonConvert.DeserializeObject<IEnumerable<RssFeedBasicInfo>>(response.Result.Content.ReadAsStringAsync().Result)
                }
            };
        }

        public RssFeedViewModel GetRssFeedById(int rssFeedId, int recordCount)
        {
            var response = _httpClient.GetAsync("https://localhost:44329/NewsSiteApi/RssFeed/1/10");
            return new RssFeedViewModel
            {
                RssFeedItems = JsonConvert.DeserializeObject<IEnumerable<RootObject>>(response.Result.Content.ReadAsStringAsync().Result)
            };
        }
    }
}
