using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Models;

[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set;}

    [Column("name")]
    [Required]
    [MaxLength(100)]
    public required string Name { get; set;}

    [Column("description")]
    [MaxLength(400)]
    public string? Description { get; set;}

    [Column("price")]
    [Required]
    public double Price { get; set;}

    [Column("stock")]
    [Required]
    public int Stock { get; set;}

    [Column("category_id")]
    [ForeignKey("Category")]
    [Required]
    public int CategoryId { get; set;}

    //Empty constructor
    public Product(){}

    public Product(int id, string name, double price, int stock, int categoryId, string? description = null)
    {
        Id = id;
        Name = name.Trim().ToLower();
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
        Description = description.Trim().ToLower();
    }
}
