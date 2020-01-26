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

        public IEnumerable<RssFeed> GetAllRssFeeds()
        {
            return _newsSiteContext.RssFeed.ToList();
        }

        public string GetRssFeedUriById(int rssFeedId)
        {
           return _newsSiteContext.RssFeed.Where(r => r.Id == rssFeedId).Select(r => r.Uri).FirstOrDefault();
        }
    }
}
