using System;
using System.ComponentModel.DataAnnotations;

namespace DataImporter.Repository
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


}
