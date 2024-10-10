using Microsoft.AspNetCore.Mvc;
using ProductsAPI.DTOs;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
public class CategoriesUpdateController : CategoriesController
{
    public CategoriesUpdateController(ICategoryRepository categoryRepository) : base(categoryRepository){}

    //PUT: /api/v1/categories/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] CategoryDTO categoryDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingCategory = await _categoryRepository.GetById(id);
        if (existingCategory == null)
        {
            return NotFound($"Category with id {id} not found.");
        }

        existingCategory.Name = categoryDTO.Name;
        existingCategory.Description = categoryDTO.Description;

        try
        {
            await _categoryRepository.Update(existingCategory);
            return Ok(existingCategory);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }


}
