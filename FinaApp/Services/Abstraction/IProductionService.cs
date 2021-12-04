using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinaData.Models;

namespace FinaApp.Services.Abstraction;

public interface IProductionService
{
    Task CreateProductAsync(ProductModel product);
    ProductModel GetProductByIdAsync(int id);
    Task UpdateProductAsync(ProductModel product);
    Task DeleteProductAsync(ProductModel product);
    Task DeleteProductRangeAsync(ICollection<ProductModel> product);
}
