using NewsSiteAPI.Models;
using System.Collections.Generic;

namespace NewsSiteAPI.Repositories.Contracts
{
    public interface IRssFeedRepository
    {
        IEnumerable<RssFeed> GetAllRssFeeds();
    }
}
