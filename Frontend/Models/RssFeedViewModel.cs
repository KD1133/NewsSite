using Frontend.Deseriliazation_objects;
using System.Collections.Generic;

namespace Frontend.Models
{
    public class RssFeedViewModel
    {
        public IEnumerable<RssFeedItem> RssFeedItems { get; set; }
    }
}
