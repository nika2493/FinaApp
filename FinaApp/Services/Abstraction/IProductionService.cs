using FinaData.Models;

namespace FinaApp.Services.Abstraction;

public interface IProductionService
{
    //ProductCRUD
    void CreateProduct(ProductModel product);
    ProductModel GetProductById(int id);
    void UpdateProduct(ProductModel product);
    void DeleteProduct(ProductModel product);
    void DeleteProductRange(IEnumerable<ProductModel> products);
    //GroupCrud
    void CreateGroup(GroupModel group);
    GroupModel GetGroupById(int id);
    List<GroupModel> GetAllGroup();
    void UpdateGroup(GroupModel group);
    void DeleteGroup(GroupModel group);
    void DeleteGroupRange(IEnumerable<GroupModel> groups);
    //CountryCRUD
    void CreateCountry(CountryModel country);
    CountryModel GetCountryById(int id);
    CountryModel? GetCountryByName(string name);
    List<CountryModel> GetAllCountries();
    void UpdateCountry(CountryModel country);
    void DeleteCountry(CountryModel country);
    void DeleteCountryRange(IEnumerable<CountryModel> countries);
    //Utility
    List<GroupModel> GetSelectedTree(GroupModel group);
    List<GroupModel> GetAllChildGroupById(int? id);
    List<ProductModel> GetProductsByGroup(GroupModel group);
    bool GroupHasChildGroup(GroupModel group);
    List<int> GetAllProductCodes();
    List<string> GetAllProductNames();
    List<string> GetAllGroupNames();
}
