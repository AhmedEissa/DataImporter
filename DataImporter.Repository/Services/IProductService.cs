using System.Threading.Tasks;

namespace DataImporter.Repository.Services
{
    public interface IProductService
    {
        Task SaveAsync(Product product);
        Task GetByIdAsync(int id);
        Task GetAllAsync();
    }
}