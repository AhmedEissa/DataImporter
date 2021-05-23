using System;
using System.Collections.Generic;
using System.Text;

namespace DataImporter.Core.Entities
{
    class Feed
    {
        public int id { get; set; }
        public int compID { get; set; }
        public string Name { get; set; }
        public DateTime addedWhen { get; set; }
        public string addedBy { get; set; }
    }
}
