using Frontend.Models;

namespace Frontend.Providers.Interfaces
{
    public interface IRssFeedProvider
    {
        HomeViewModel GetAllRssFeeds();
    } 
}
