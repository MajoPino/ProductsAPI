using ProductsAPI.Models;

namespace ProductsAPI.Repositories;
public interface ICategoryRepository
{
    //Get all categories
    Task<IEnumerable<Category>> GetAll();

    //Get category by id
    Task<Category> GetById(int id);

    //Create a new category
    Task Create(Category category);

    //Update an existing category
    Task Update(Category category);

    //Delete a category
    Task Delete(int id);
}
