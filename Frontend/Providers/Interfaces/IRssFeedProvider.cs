using Frontend.Models;

namespace Frontend.Providers.Interfaces
{
    public interface IRssFeedProvider
    {
        RssFeedViewModel GetAllRssFeeds();
    }
}
