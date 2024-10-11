using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace ProductsAPI.Controllers.V1.Products;

[ApiController]
[Route("api/v1/products")]
[Tags("Categories")]
public class ProductDeleteController : ProductsController
{
    public ProductDeleteController(IProductRepository productRepository) : base(productRepository){}

    //DELETE: /api/v1/products/{id}
    [HttpDelete("{id}")]
    [SwaggerOperation(
        Summary = "Delete a category",
        Description = "Removes a category from the system by its ID"
    )]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _productRepository.Delete(id);
            return Ok("Product deleted successfully!");
        }
        catch (ArgumentNullException)
        {
            return NotFound($"Product with id {id} not found.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
