using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Core.Services
{
    interface ICSVService
    {
        Task PopulateAsync(string feedPath, string companyIdentifier);
    }
}
