using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
public class CategoriesDeleteController : CategoriesController
{
    public CategoriesDeleteController(ICategoryRepository categoryRepository) : base(categoryRepository){}

    //DELETE: /api/v1/categories/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _categoryRepository.Delete(id);
            return Ok("Category deleted successfully!");
        }
        catch (ArgumentNullException)
        {
            return NotFound($"Category with id {id} not found.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
