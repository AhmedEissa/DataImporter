using System.Data.Entity;

namespace DataImporter.Core
{
    public class CompaniesDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}
