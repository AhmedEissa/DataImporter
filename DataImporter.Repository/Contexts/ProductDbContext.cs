using System.Data.Entity;

namespace DataImporter.Repository
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
