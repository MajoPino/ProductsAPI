using Microsoft.AspNetCore.Mvc;
using ProductsAPI.DTOs;
using ProductsAPI.Models;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers.V1.Products;

[ApiController]
[Route("api/v1/products")]
public class ProductsCreateController : ProductsController
{
    public ProductsCreateController(IProductRepository productRepository) : base(productRepository){}

    //POST: /api/v1/products
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProductDTO productDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var product = new Product
        {
            Name = productDTO.Name,
            Description = productDTO.Description,
            Price = productDTO.Price,
            Stock = productDTO.Stock,
            CategoryId = productDTO.CategoryId
        };

        try
        {
            await _productRepository.Create(product);
            return Ok(product);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
