using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Core.Services
{
    public class CSVService : ICSVService
    {
      
        public Task PopulateAsync(string feedPath, string companyIdentifier)
        {
            //var dbData = ReadCSV(feedPath);

            throw new NotImplementedException();
        }

       
    }
}
