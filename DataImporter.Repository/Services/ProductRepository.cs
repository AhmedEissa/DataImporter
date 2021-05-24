using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DataImporter.Repository.Contexts;

namespace DataImporter.Repository.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataImporterDbContext _dataImporterDbContext;

        public ProductRepository(DataImporterDbContext dataImporterDbContext)
        {
            this._dataImporterDbContext = dataImporterDbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dataImporterDbContext.Products;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _dataImporterDbContext.Products.FindAsync(id);
        }

        public async Task SaveAsync(Product product)
        {
            _dataImporterDbContext.Products.Add(product);
            await _dataImporterDbContext.SaveChangesAsync();
        }
        public async Task SaveAsync(List<Product> products)
        {
            foreach (var product in products)
            {
                _dataImporterDbContext.Products.Add(product);
            }

            await _dataImporterDbContext.SaveChangesAsync();
        }
    }
}
