using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.DTOs;
public class CategoryDTO
{
    [Required(ErrorMessage ="The name is required")]
    [MaxLength(100, ErrorMessage = "The name is too long")]
    public required string Name { get; set; }

    [MaxLength(400, ErrorMessage ="The description is too long")]
    public string? Description { get; set; }
}
