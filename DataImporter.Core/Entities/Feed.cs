using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DataImporter.Core.Entities
{
    public class Feed
    {
        public int id { get; set; }
        [Required]
        public int compID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime addedWhen { get; set; }
        [Required]
        public string addedBy { get; set; }
    }

    internal class MyFeed : DbContext
    {
        public DbSet<Feed> Feeds { get; set; }
    }
}
