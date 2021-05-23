using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataImporter.Repository.Services
{
    public interface IProductRepository
    {
        Task SaveAsync(Product product);
        Task<Product> GetByIdAsync(int id);
        IEnumerable<Product> GetAllAsync();
    }
}