using System.Data.Entity;

namespace DataImporter.Core
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
