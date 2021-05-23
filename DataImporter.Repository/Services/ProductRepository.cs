using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Repository.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllAsync()
        {
            return dbContext.Products;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await dbContext.Products.FindAsync(id);
        }

        public async Task SaveAsync(Product product)
        {
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync(); 
        }
    }
}
