using Microsoft.AspNetCore.Mvc;
using ProductsAPI.DTOs;
using ProductsAPI.Models;
using ProductsAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace ProductsAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("Categories")]
public class CategoriesCreateController : CategoriesController
{
    public CategoriesCreateController(ICategoryRepository categoryRepository) : base(categoryRepository){}

    //POST: /api/v1/categories
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new category",
        Description = "Adds a new category to the system."
    )]
    public async Task<IActionResult> Create([FromBody] CategoryDTO categoryDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var category = new Category
        {
            Name = categoryDTO.Name,
            Description = categoryDTO.Description
        };

        try
        {
            await _categoryRepository.Create(category);
            return Ok(category);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
