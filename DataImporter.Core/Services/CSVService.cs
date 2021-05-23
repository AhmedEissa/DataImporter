using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataImporter.Repository;
using DataImporter.Repository.Contexts;

namespace DataImporter.Core.Services
{
    public class CSVService : ICSVService
    {
        public Task<IEnumerable<Product>> PopulateAsync(string feedPath, string companyIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}
