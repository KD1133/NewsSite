using System.Collections.Generic;
using System.Linq;
using NewsSiteAPI.Repositories.Contracts;
using NewsSiteAPI.Models;

namespace NewsSiteAPI.Repositories.Implementations
{
    public class RssFeedRepository : IRssFeedRepository
    {
        readonly NewsSiteContext _newsSiteContext;

        public RssFeedRepository(NewsSiteContext context)
        {
            _newsSiteContext = context;
        }

        /// <summary>
        /// Gets all rss feed basic info
        /// </summary>
        public IEnumerable<RssFeed> GetAllRssFeeds()
        {
            return _newsSiteContext.RssFeed.ToList();
        }

        /// <summary>
        /// Gets rss feed data by itrs id
        /// </summary>
        /// <param name="rssFeedId">Feeds id</param>
        public string GetRssFeedUriById(int rssFeedId)
        {
           return _newsSiteContext.RssFeed.Where(r => r.Id == rssFeedId).Select(r => r.Uri).FirstOrDefault();
        }
    }
}
