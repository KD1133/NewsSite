using System;
using System.ComponentModel.DataAnnotations;

namespace NewsSiteAPI.Models
{
    public class RSSFeed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public string Uri { get; set; }
    }
}
