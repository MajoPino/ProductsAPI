using ProductsAPI.Models;

namespace ProductsAPI.Repositories;
public interface IProductRepository
{
    //Get all products
    Task<IEnumerable<Product>> GetAll();

    //Get product by id
    Task<Product> GetById(int id);

    //Create a new product
    Task Create(Product product);

    //Update an existing product
    Task Update(Product product);

    //Delete a product
    Task Delete(int id);
}
