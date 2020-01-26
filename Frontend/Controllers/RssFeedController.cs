using Frontend.Models;
using Frontend.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    [Route("/RssFeed")]
    public class RssFeedController : Controller
    {
        private readonly IRssFeedProvider _rssFeedProvider;

        public RssFeedController(IRssFeedProvider rssFeedProvider)
        {
            this._rssFeedProvider = rssFeedProvider;
        }

        /// <summary>
        /// Displays a amount of items form rss feed
        /// </summary>
        /// <param name="rssFeedId">Rss Feeds Id</param>
        /// <param name="recordCount">Amount of records to load</param>
        // TODO move recordCount to [form query]
        [HttpGet]
        [Route("{rssFeedId}/{recordCount}")]
        public ActionResult Details(int rssFeedId, int recordCount)
        {
            RssFeedViewModel model = _rssFeedProvider.GetRssFeedById(rssFeedId, recordCount);
            return View("Views/RssFeed.cshtml", model);
        }
    }
}