using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Repositories;

namespace ProductsAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
public class CategoriesController : ControllerBase
{
    protected readonly ICategoryRepository _categoryRepository;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
}
