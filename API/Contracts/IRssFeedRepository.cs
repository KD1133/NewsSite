using System.Collections.Generic;

namespace NewsSiteAPI.Contracts
{
    interface IRssFeedRepository<T>
    {
        IEnumerable<T> GetAllRssFeeds();
    }
}
