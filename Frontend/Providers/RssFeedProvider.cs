using Frontend.Deseriliazation_objects;
using Frontend.Models;
using Frontend.Providers.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace Frontend.Providers
{
    public class RssFeedProvider : IRssFeedProvider
    {
        private readonly HttpClient _httpClient;
        private const string ConectionStringBase = "https://localhost:44329/NewsSiteApi/RssFeed";

        public RssFeedProvider()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Gets all Rss Feed basic data
        /// </summary>
        public HomeViewModel GetAllRssFeeds()
        {
            var response = _httpClient.GetAsync($"{ConectionStringBase}/All");
            return new HomeViewModel
            {
                RssFeedsViewModel = new RssFeedsViewModel
                {
                    RssFeeds = JsonConvert.DeserializeObject<IEnumerable<RssFeedBasicInfo>>(response.Result.Content.ReadAsStringAsync().Result)
                }
            };
        }

        /// <summary>
        /// Displays a amount of items form rss feed
        /// </summary>
        /// <param name="rssFeedId">Rss Feeds Id</param>
        /// <param name="recordCount">Amount of records to load</param>
        public RssFeedViewModel GetRssFeedById(int rssFeedId, int recordCount)
        {
            var response = _httpClient.GetAsync($"{ ConectionStringBase}/{rssFeedId}/{recordCount}");
            return new RssFeedViewModel
            {
                RssFeedItems = JsonConvert.DeserializeObject<IEnumerable<RssFeedItem>>(response.Result.Content.ReadAsStringAsync().Result)
            };
        }
    }
}
