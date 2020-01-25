using System.ComponentModel.DataAnnotations;

namespace NewsSiteAPI.Models
{
    public class RssFeed
    {
        [Key]
        public int RssFeedId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Uri { get; set; }
    }
}
