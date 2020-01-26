using System;

namespace Frontend.Deseriliazation_objects
{
    /// <summary>
    /// Class uised to deserialize Rss Feed
    /// </summary>
    public class Link
    {
        public string Uri { get; set; }
        public object Title { get; set; }
        public object MediaType { get; set; }
        public string RelationshipType { get; set; }
        public int Length { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
