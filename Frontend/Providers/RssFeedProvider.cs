using Frontend.Models;
using Frontend.Providers.Interfaces;
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

        public RssFeedViewModel GetAllRssFeeds()
        {
            var response = _httpClient.GetAsync("https://localhost:44329/NewsSiteApi/RssFeeds");

        }
    }
}
