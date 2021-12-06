using FinaApp.Services.Abstraction;
using FinaData.Data;
using FinaData.Models;
using Microsoft.EntityFrameworkCore;

namespace FinaApp.Services;

public class ProductionService : IProductionService
{
    private readonly ProductionDbContext _db;
    public ProductionService(ProductionDbContext context)
    {
        _db = context;
    }
    //ProductCRUD
    public void CreateProduct(ProductModel product)
    {
        _db.Products.Add(product);
        _db.SaveChanges();
    }
    public ProductModel GetProductById(int id)
    {
        return  _db.Products.First(x => x.Id == id);
    }
    public  void UpdateProduct(ProductModel product)
    {
        _db.Products.Update(product);
        _db.SaveChanges();
    }
    public  void DeleteProduct(ProductModel product)
    {
        _db.Products.Remove(product);
        _db.SaveChanges();
    }
    public  void DeleteProductRange(IEnumerable<ProductModel> products)
    {
        _db.Products.RemoveRange(products);
        _db.SaveChanges();
    }
    //GroupCRUD
    public  void CreateGroup(GroupModel group)
    {
        _db.Groups.Add(group);
        _db.SaveChanges();
    }
    public  GroupModel GetGroupById(int id)
    {
        return  _db.Groups.First(x => x.Id == id);
    }
    public List<GroupModel> GetAllGroup()
    {
        return _db.Groups.ToList();
    }
    public  void UpdateGroup(GroupModel group)
    {
        _db.Groups.Update(group);
        _db.SaveChanges();
    }
    public  void DeleteGroup(GroupModel group)
    {
        _db.Groups.Remove(group);
        _db.SaveChanges();
    }
    public  void DeleteGroupRange(IEnumerable<GroupModel> groups)
    {
        _db.Groups.RemoveRange(groups);
        _db.SaveChanges();
    }
    //CountryCRUD
    public  void CreateCountry(CountryModel country)
    {
        _db.Countries.Add(country);
        _db.SaveChanges();
    }
    public CountryModel GetCountryById(int id)
    {
        return  _db.Countries.First(x => x.Id == id);
    }

    public CountryModel? GetCountryByName(string name)
    {
        return _db.Countries.FirstOrDefault(x => x.Name == name);
    }
    public  List<CountryModel> GetAllCountries()
    {
        try
        {
            return _db.Countries.ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
    public  void UpdateCountry(CountryModel country)
    {
        _db.Countries.Update(country);
        _db.SaveChanges();
    }
    public  void DeleteCountry(CountryModel country)
    {

        _db.Countries.Remove(country);
        _db.SaveChanges();

    }
    public void DeleteCountryRange(IEnumerable<CountryModel> countries)
    {
        _db.Countries.RemoveRange(countries);
        _db.SaveChanges();
    }
    //Utility
    public List<GroupModel> GetAllChildGroupById(int? id)
    {
        return _db.Groups.Include(gr => gr.Production).Include(gr => gr.ParentGroup)
            .Where(gr => (id == null && gr.ParentGroup == null)
                         || (gr.ParentGroup != null && gr.ParentGroup.Id == id)).ToList();
    }
    public List<ProductModel> GetProductsByGroup(GroupModel group)
    {
        return _db.Products.Where(x => x.Group == group).ToList();
    }
    public bool GroupHasChildGroup(GroupModel group)
    {
        return _db.Groups.Any(x => x.ParentGroup == group);
    }

    public List<int> GetAllProductCodes()
    {
        return _db.Products.Select(x => x.Code).ToList();
    }

    public List<string> GetAllProductNames()
    {
        return _db.Products.Select(x => x.Name).ToList();
    }

    public List<string> GetAllGroupNames()
    {
        return _db.Groups.Select(x => x.Name).ToList();
    }
}
