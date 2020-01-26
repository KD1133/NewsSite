using Microsoft.AspNetCore.Mvc;
using Microsoft.SyndicationFeed;
using NewsSiteAPI.Logic.Interfaces;
using NewsSiteAPI.Models;
using NewsSiteAPI.Repositories.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NewsSiteAPI.Controllers
{
    [Route("NewsSiteApi/RssFeed")]
    [ApiController]
    public class RssFeedsController : ControllerBase
    {
        private readonly IRssFeedRepository _rssFeedRepository;
        private readonly IRssFeedLogic _RssFeedLogic;

        public RssFeedsController(IRssFeedRepository rssFeedRepository, IRssFeedLogic RssFeedLogic)
        {
            _rssFeedRepository = rssFeedRepository;
            _RssFeedLogic = RssFeedLogic;
        }

        /// <summary>
        /// Gets all Rss Feed basic data
        /// </summary>
        [HttpGet]
        [Route("All")]
        public IActionResult GetAllRssFeed()
        {
            IEnumerable<RssFeed> rssFeeds = _rssFeedRepository.GetAllRssFeeds();
            return Ok(rssFeeds);
        }

        /// <summary>
        /// returns a amount of items form rss feed
        /// </summary>
        /// <param name="rssFeedId">Rss Feeds Id</param>
        /// <param name="recordCount">Amount of records to load</param>
        [HttpGet]
        [Route("{rssFeedId}/{recordCount}")]
        public IActionResult GetRssFeedData(int rssFeedId, int recordCount)
        {
            IEnumerable<ISyndicationItem> rssFeedItems = _RssFeedLogic.GetRssFeedData(rssFeedId, recordCount).Result;
            return Ok(rssFeedItems);
        }
    }
}
