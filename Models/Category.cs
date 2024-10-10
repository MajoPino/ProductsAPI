using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Models;

[Table("categories")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }

    [Column("description")]
    [MaxLength(400)]
    public string? Description { get; set; }

    public Category(){}

    public Category(int id, string name, string description)
    {
        Id = id;
        Name = name.ToLower().Trim();
        Description = description.ToLower().Trim();
    }
}
