using Frontend.Models;

namespace Frontend.Providers.Interfaces
{
    public interface IRssFeedProvider
    {
        /// <summary>
        /// Gets all Rss Feed basic data
        /// </summary>
        HomeViewModel GetAllRssFeeds();

        /// <summary>
        /// Displays a amount of items form rss feed
        /// </summary>
        /// <param name="rssFeedId">Rss Feeds Id</param>
        /// <param name="recordCount">Amount of records to load</param>
        RssFeedViewModel GetRssFeedById(int rssFeedId, int recordCount);
    } 
}
