using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.DTOs;
    public class ProductDTO
    {
    [Required(ErrorMessage = "The Product Name is required")]
    [MaxLength(100, ErrorMessage = "The Product Name is too long")]
    public required string Name { get; set;}

    [MaxLength(400, ErrorMessage = "The Product Description is too long")]
    public string? Description { get; set;}

    [Required(ErrorMessage = "The Product Price is required")]
    public double Price { get; set;}

    [Required(ErrorMessage = "The Product Stock quantity is required")]
    public int Stock { get; set;}

    [Required(ErrorMessage = "The Product Category Id is required")]
    public int CategoryId { get; set;}
    }
