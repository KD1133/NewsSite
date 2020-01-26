using NewsSiteAPI.Models;
using System.Collections.Generic;

namespace NewsSiteAPI.Repositories.Contracts
{
    public interface IRssFeedRepository
    {
        /// <summary>
        /// Gets all rss feed basic info
        /// </summary>
        IEnumerable<RssFeed> GetAllRssFeeds();

        /// <summary>
        /// Gets rss feed data by itrs id
        /// </summary>
        /// <param name="rssFeedId">Feeds id</param>
        string GetRssFeedUriById(int rssFeedId);
    }
}
