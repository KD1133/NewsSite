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

        public RssFeedProvider()
        {
            _httpClient = new HttpClient();
        }

        public HomeViewModel GetAllRssFeeds()
        {
            var response = _httpClient.GetAsync("https://localhost:44329/NewsSiteApi/RssFeeds");
            IEnumerable<RssFeedBasicInfo> rssFeedBasicInfos = JsonConvert.DeserializeObject<IEnumerable<RssFeedBasicInfo>>(response.ToString());
            return new HomeViewModel
            {
                RssFeedViewModel = new RssFeedViewModel()
            };
        }
    }
}
