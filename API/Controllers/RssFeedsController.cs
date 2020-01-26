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

        // GET: NewsSiteApi/RssFeed/All
        [HttpGet]
        [Route("All")]
        public IActionResult GetAllRssFeed()
        {
            IEnumerable<RssFeed> rssFeeds = _rssFeedRepository.GetAllRssFeeds();
            return Ok(rssFeeds);
        }

        // GET: NewsSiteApi/RssFeed/1/10
        [HttpGet]
        [Route("{rssFeedId}/{recordCount}")]
        public IActionResult GetRssFeedData(int rssFeedId, int recordCount)
        {
            IEnumerable<ISyndicationItem> rssFeedItems = _RssFeedLogic.GetRssFeedData(rssFeedId, recordCount).Result;
            return Ok(rssFeedItems);
        }
    }
}
