using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Seeders;
public class CategorySeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category {
                Id = 1,
                Name = "Electronics",
                Description = "All electronic products."
            },
            new Category {
                Id = 2,
                Name = "Clothing",
                Description = "All clothing products."
            },
            new Category {
                Id = 3,
                Name = "Books",
                Description = "All books products."
            },
            new Category {
                Id = 4,
                Name = "Home & Garden",
                Description = "All home and garden products."
            },
            new Category {
                Id = 5,
                Name = "Sports & Outdoors",
                Description = "All sports and outdoor products."
            },
            new Category {
                Id = 6,
                Name = "Toys & Games",
                Description = "All toys and games products."
            },
            new Category {
                Id = 7,
                Name = "Health & Beauty",
                Description = "All health and beauty products."
            },
            new Category {
                Id = 8,
                Name = "Automotive",
                Description = "All automotive products."
            },
            new Category {
                Id = 9,
                Name = "Office Supplies",
                Description = "All office supplies products."
            },
            new Category {
                Id = 10,
                Name = "Cooking",
                Description = "All cooking supplies."
            }
        ); 
    }
}
