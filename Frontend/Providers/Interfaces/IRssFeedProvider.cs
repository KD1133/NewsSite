using Frontend.Models;

namespace Frontend.Providers.Interfaces
{
    public interface IRssFeedProvider
    {
        HomeViewModel GetAllRssFeeds();

        RssFeedViewModel GetRssFeedById(int rssFeedId, int recordCount);
    } 
}
