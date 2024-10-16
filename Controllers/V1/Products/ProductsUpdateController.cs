using Microsoft.AspNetCore.Mvc;
using ProductsAPI.DTOs;
using ProductsAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace ProductsAPI.Controllers.V1.Products;

[ApiController]
[Route("api/v1/products")]
[Tags("Products")]
public class ProductsUpdateController : ProductsController
{
    public ProductsUpdateController(IProductRepository productRepository) : base(productRepository){}

    //PUT: /api/v1/products/{id}
    [HttpPut("{id}")]
    [SwaggerOperation(
        Summary = "Update a product",
        Description = "Modifies an existing product in the system by its ID"
    )]
    public async Task<IActionResult> Update(int id, [FromBody] ProductDTO productDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingProduct = await _productRepository.GetById(id);
        if (existingProduct == null)
        {
            return NotFound($"Product with id {id} not found.");
        }

        existingProduct.Name = productDTO.Name;
        existingProduct.Description = productDTO.Description;
        existingProduct.Price = productDTO.Price;
        existingProduct.Stock = productDTO.Stock;
        existingProduct.CategoryId = productDTO.CategoryId;

        try
        {
            await _productRepository.Update(existingProduct);
            return Ok(existingProduct);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

}
