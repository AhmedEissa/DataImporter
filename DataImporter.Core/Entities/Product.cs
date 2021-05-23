using System;
using System.Collections.Generic;
using System.Text;

namespace DataImporter.Core.Entities
{
    class Product
    {
        public int id { get; set; }
        public int feedId { get; set; }
        public int compId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public DateTime addedWhen { get; set; }
        public string addedBy { get; set; }
    }
}
