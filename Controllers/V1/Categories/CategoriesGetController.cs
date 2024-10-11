using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
public class CategoriesGetController : CategoriesController
{
    public CategoriesGetController(ICategoryRepository categoryRepository) : base(categoryRepository) { }

    //GET: /api/v1/categories

    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        try
        {
            var categories = await _categoryRepository.GetAll();
            return Ok(categories);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An unexpected error occurred.");
        }
    }

    //GET: api/v1/categories/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        try
        {
            var category = await _categoryRepository.GetById(id);

            if (category == null)
            {
                return NotFound($"Category with id {id} is not found.");
            }

            return Ok(category);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An unexpected error occurred. Exception: {ex.Message}");
        }
    }
}
