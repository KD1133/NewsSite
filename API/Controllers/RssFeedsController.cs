using Microsoft.AspNetCore.Mvc;
using NewsSiteAPI.Repositories.Contracts;
using NewsSiteAPI.Repositories.Implementations;
using NewsSiteAPI.Models;
using System.Collections.Generic;

namespace NewsSiteAPI.Controllers
{
    [Route("NewsSiteApi")]
    [ApiController]
    public class RssFeedsController : ControllerBase
    {
        private readonly IRssFeedRepository _rssFeedRepository;

        public RssFeedsController(IRssFeedRepository rssFeedRepository)
        {
            _rssFeedRepository = rssFeedRepository;
        }

        // GET: NewsSiteApi/RssFeeds
        [HttpGet]
        [Route("RssFeeds")]
        public IActionResult GetRssFeed()
        {
            IEnumerable<RssFeed> rssFeeds = _rssFeedRepository.GetAllRssFeeds();
            return Ok(rssFeeds);
        }
    }
}
