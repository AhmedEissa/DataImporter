using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DataImporter.Core.Entities
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public int feedId { get; set; }
        [Required]
        public int compId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime addedWhen { get; set; }
        [Required]
        public string addedBy { get; set; }
    }

    internal class MyProduct : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
