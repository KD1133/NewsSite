using Microsoft.SyndicationFeed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsSiteAPI.Logic.Interfaces
{
    public interface IRssFeedLogic
    {
        Task<IEnumerable<ISyndicationItem>> GetRssFeedData(int rssFeedId, int recordCount);
    }
}
