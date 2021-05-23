using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataImporter.Repository;

namespace DataImporter.Core.Services
{
    interface ICSVService
    {
        Task<IEnumerable<Product>> PopulateAsync(string feedPath, string companyIdentifier);
    }
}
