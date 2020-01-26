using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Rss;
using NewsSiteAPI.Logic.Interfaces;
using NewsSiteAPI.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace NewsSiteAPI.Logic
{
    public class RssFeedLogic : IRssFeedLogic
    {
        private readonly IRssFeedRepository _rssFeedRepository;

        public RssFeedLogic(IRssFeedRepository rssFeedRepository)
        {
            _rssFeedRepository = rssFeedRepository;
        }

        public async Task<IEnumerable<ISyndicationItem>> GetRssFeedData(int rssFeedId, int recordCount)
        {
            var items = new List<ISyndicationItem>();
            var rssFeedUri = _rssFeedRepository.GetRssFeedUriById(rssFeedId);

            using (var xmlReader = XmlReader.Create(rssFeedUri, new XmlReaderSettings() { Async = true }))
            {
                var feedReader = new RssFeedReader(xmlReader);
                while (await feedReader.Read())
                {
                    if (feedReader.ElementType == Microsoft.SyndicationFeed.SyndicationElementType.Item)
                    {
                        ISyndicationItem item = await feedReader.ReadItem();
                        items.Add(item);
                    }
                }
            }
            return items.Take(recordCount);
        } 
    }
}
