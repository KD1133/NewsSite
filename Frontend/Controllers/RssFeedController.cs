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

        // GET: RssFeed/1/10
        [HttpGet]
        [Route("{rssFeedId}/{recordCount}")]
        public ActionResult Details(int rssFeedId, int recordCount)
        {
            RssFeedViewModel model = _rssFeedProvider.GetRssFeedById(rssFeedId, recordCount);
            return View("Views/RssFeed.cshtml", model);
        }
    }
}