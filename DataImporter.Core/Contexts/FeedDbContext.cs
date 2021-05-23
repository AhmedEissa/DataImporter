using System.Data.Entity;

namespace DataImporter.Core
{
    public class FeedDbContext : DbContext
    {
        public DbSet<Feed> Feeds { get; set; }
    }
}
