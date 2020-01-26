using Frontend.Models;
using Frontend.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRssFeedProvider _rssFeedProvider;

        public HomeController(IRssFeedProvider rssFeedProvider)
        {
            this._rssFeedProvider = rssFeedProvider;
        }

        /// <summary>
        /// Displays home view
        /// </summary>
        public ActionResult Home()
        {
            HomeViewModel model = _rssFeedProvider.GetAllRssFeeds();
            return View("Views/Home.cshtml",model);
        }
    }
}