using System.Data.Entity;

namespace DataImporter.Repository
{
    public class FeedDbContext : DbContext
    {
        public DbSet<Feed> Feeds { get; set; }
    }
}
