using System;
using System.Collections.Generic;

namespace Frontend.NeededForSerialization
{
    public class Link
    {
        public string Uri { get; set; }
        public object Title { get; set; }
        public object MediaType { get; set; }
        public string RelationshipType { get; set; }
        public int Length { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public class RootObject
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
