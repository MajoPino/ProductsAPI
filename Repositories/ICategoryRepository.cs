using ProductsAPI.Models;

namespace ProductsAPI.Repositories;
public interface ICategoryRepository
{
    //Get all categories
    Task<IEnumerable<Category>> GetAllCategories();

    //Get category by id
    Task<Category> GetCategoryById(int id);

    //Create a new category
    Task CreateCategory(Category category);

    //Update an existing category
    Task UpdateCategory(Category category);

    //Delete a category
    Task DeleteCategory(int id);
}
