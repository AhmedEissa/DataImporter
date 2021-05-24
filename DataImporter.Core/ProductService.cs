using DataImporter.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataImporter.Repository;
using DataImporter.Repository.Services;

namespace DataImporter.Core
{
  public class ProductService : IProductService
  {
      private readonly IProductRepository _productRepository;

      public ProductService(IProductRepository productRepository)
      {
          _productRepository = productRepository;
      }
      public Task<Product> GetByIdAsync(int id)
      {
          return _productRepository.GetByIdAsync(id);
      }

      public IEnumerable<Product> GetAllAsync()
      {
          return _productRepository.GetAll();
      }
  }
}
