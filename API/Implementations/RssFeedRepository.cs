using System.Collections.Generic;
using System.Linq;
using NewsSiteAPI.Contracts;
using NewsSiteAPI.Models;

namespace NewsSiteAPI.Implementations
{
    public class RssFeedRepository : IRssFeedRepository<RssFeed>
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
    }
}
