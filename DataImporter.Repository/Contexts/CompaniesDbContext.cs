using System.Data.Entity;

namespace DataImporter.Repository
{
    public class CompaniesDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}
