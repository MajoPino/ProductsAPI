using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers.V1.Products;

[ApiController]
[Route("api/v1/products")]
public class ProductsGetController : ProductsController
{
    public ProductsGetController(IProductRepository productRepository) : base(productRepository){}

    //GET: /api/v1/products

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        try
        {
            var products = await _productRepository.GetAll();
            return Ok(products);
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

    //GET: api/v1/products/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        try
        {
            var product = await _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound($"Product with id {id} is not found.");
            }

            return Ok(product);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An unexpected error occurred. Exception: {ex.Message}");
        }
    }
}
