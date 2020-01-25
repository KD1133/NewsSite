using Microsoft.EntityFrameworkCore;
using NewsSiteAPI.Models;

namespace NewsSiteAPI
{
    public class NewsSiteContext : DbContext
    {
        public DbSet<RssFeed> RssFeed { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=NewsSite.db");
    }
}
