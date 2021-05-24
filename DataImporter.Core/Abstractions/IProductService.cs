using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataImporter.Repository;

namespace DataImporter.Core.Abstractions
{
  public interface IProductService
  {
      Task<Product> GetByIdAsync(int id);
      IEnumerable<Product> GetAllAsync();
    }
}
