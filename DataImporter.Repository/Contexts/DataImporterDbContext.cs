using Microsoft.EntityFrameworkCore;

namespace DataImporter.Repository.Contexts
{
    public class DataImporterDbContext : DbContext
    {
        public DataImporterDbContext(DbContextOptions<DataImporterDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
