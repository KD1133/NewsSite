using System;
using System.Collections.Generic;

namespace Frontend.Deseriliazation_objects
{
    /// <summary>
    /// Class uised to deserialize Rss Feed
    /// </summary>
    public class RssFeedItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<object> Categories { get; set; }
        public List<object> Contributors { get; set; }
        public List<Link> Links { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Published { get; set; }
    }
}
