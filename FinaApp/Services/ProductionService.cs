using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinaApp.Services.Abstraction;
using FinaData.Data;
using FinaData.Models;

namespace FinaApp.Services;

public class ProductionService : IProductionService
{
    private readonly ProductionDbContext _db;
    public ProductionService(ProductionDbContext context)
    {
        _db = context;
    }

    public async Task CreateProductAsync(ProductModel product)
    {
        throw new NotImplementedException();
    }
    public ProductModel GetProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateProductAsync(ProductModel product)
    {
        throw new NotImplementedException();
    }
    public async Task DeleteProductAsync(ProductModel product)
    {
        _db.Products.Remove(product);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteProductRangeAsync(ICollection<ProductModel> products)
    {
        _db.Products.RemoveRange(products);
        await _db.SaveChangesAsync();
    }
}
