using Microsoft.AspNetCore.Mvc;
using NewsSiteAPI.Contracts;
using NewsSiteAPI.Implementations;
using NewsSiteAPI.Models;
using System.Collections.Generic;

namespace NewsSiteAPI.Controllers
{
    [Route("api/RssFeed")]
    [ApiController]
    public class RssFeedsController : ControllerBase
    {
        private readonly IRssFeedRepository<RssFeed> _rssFeedRepository;

        public RssFeedsController(RssFeedRepository rssFeedRepository)
        {
            _rssFeedRepository = rssFeedRepository;
        }

        // GET: api/RssFeeds
        [HttpGet]
        [Route("GetAllRssFeeds")]
        public IActionResult GetRssFeed()
        {
            IEnumerable<RssFeed> rssFeeds = _rssFeedRepository.GetAllRssFeeds();
            return Ok(rssFeeds);
        }
    }
}
