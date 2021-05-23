using System;
using System.ComponentModel.DataAnnotations;

namespace DataImporter.Repository
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
}
