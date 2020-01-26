using Frontend.NeededForSerialization;
using Microsoft.SyndicationFeed;
using System.Collections.Generic;

namespace Frontend.Models
{
    public class RssFeedViewModel
    {
        public IEnumerable<RootObject> RssFeedItems { get; set; }
    }
}
