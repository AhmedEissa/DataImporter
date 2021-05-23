using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DataImporter.Core.Entities
{
    public class Company
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime addedWhen { get; set; }
        [Required]
        public string  addedBy { get; set; }
    }

    internal class MyCompanies : DbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}
