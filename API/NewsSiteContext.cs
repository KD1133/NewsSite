using Microsoft.EntityFrameworkCore;
using NewsSiteAPI.Models;

namespace NewsSiteAPI
{
    public class NewsSiteContext : DbContext
    {
        public DbSet<RSSFeed> RSSFeeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=NewsSite.db");
    }
}
