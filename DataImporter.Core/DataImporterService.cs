using DataImporter.Core.Abstractions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;
using DataImporter.Repository;
using DataImporter.Repository.Services;

namespace DataImporter.Core
{
    public class DataImporterService : IDataImporterService
    {
        private readonly IProductRepository _productRepository;

        public DataImporterService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async void ImportDataFromPath(string filesPath)
        {
            var products = GetProductsFromCSV(filesPath);
            await _productRepository.SaveAsync(products);
        }

        private List<Product> GetProductsFromCSV(string path)
        {
            var products = new List<Product>();


            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Product>();
                products.AddRange(records);
            }

            return products;
        }
    }
}
