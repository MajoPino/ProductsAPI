using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Seeders;
public class ProductSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Samsung Galaxy S21 Ultra",
                Description = "The latest Samsung Galaxy S21 from Samsung.",
                Price = 999.99,
                Stock = 4,
                CategoryId = 1,
            },
new Product
{
    Id = 2,
    Name = "Apple iPhone 12 Pro Max",
    Description = "The latest Apple iPhone 12 Pro Max from Apple.",
    Price = 1299.99,
    Stock = 10,
    CategoryId = 1
},
new Product
{
    Id = 3,
    Name = "Nike Air Max 97",
    Description = "The latest Nike Air Max 97 from Nike.",
    Price = 149.99,
    Stock = 20,
    CategoryId = 2
},
new Product
{
    Id = 4,
    Name = "The Alchemist",
    Description = "A philosophical novel by Paulo Coelho.",
    Price = 19.99,
    Stock = 50,
    CategoryId = 3
},
new Product
{
    Id = 5,
    Name = "Dyson V11 Vacuum Cleaner",
    Description = "High-performance vacuum cleaner for home use.",
    Price = 599.99,
    Stock = 5,
    CategoryId = 4
},
new Product
{
    Id = 6,
    Name = "Wilson Tennis Racket",
    Description = "Professional-grade tennis racket for sports enthusiasts.",
    Price = 199.99,
    Stock = 15,
    CategoryId = 5
},
new Product
{
    Id = 7,
    Name = "Lego Star Wars Millennium Falcon",
    Description = "Detailed Lego set of the Millennium Falcon.",
    Price = 149.99,
    Stock = 30,
    CategoryId = 6
},
new Product
{
    Id = 8,
    Name = "Oral-B Electric Toothbrush",
    Description = "Advanced electric toothbrush for dental care.",
    Price = 89.99,
    Stock = 100,
    CategoryId = 7
},
new Product
{
    Id = 9,
    Name = "Michelin All-Season Tires",
    Description = "Durable and high-performance tires for all seasons.",
    Price = 129.99,
    Stock = 25,
    CategoryId = 8
},
new Product
{
    Id = 10,
    Name = "HP OfficeJet Pro Printer",
    Description = "All-in-one wireless printer for office use.",
    Price = 199.99,
    Stock = 8,
    CategoryId = 9
},
new Product
{
    Id = 11,
    Name = "Instant Pot Duo",
    Description = "7-in-1 electric pressure cooker for quick meals.",
    Price = 89.99,
    Stock = 35,
    CategoryId = 10
},
new Product
{
    Id = 12,
    Name = "Sony WH-1000XM4 Headphones",
    Description = "Noise-canceling over-ear headphones for music lovers.",
    Price = 349.99,
    Stock = 20,
    CategoryId = 1
},
new Product
{
    Id = 13,
    Name = "Adidas Ultraboost 21",
    Description = "High-performance running shoes for athletes.",
    Price = 180.00,
    Stock = 60,
    CategoryId = 2
},
new Product
{
    Id = 14,
    Name = "Atomic Habits",
    Description = "A bestselling self-improvement book by James Clear.",
    Price = 24.99,
    Stock = 40,
    CategoryId = 3
},
new Product
{
    Id = 15,
    Name = "Weber Spirit Gas Grill",
    Description = "Compact gas grill for outdoor cooking.",
    Price = 499.99,
    Stock = 12,
    CategoryId = 4
},
new Product
{
    Id = 16,
    Name = "Fitbit Charge 5",
    Description = "Advanced fitness tracker with GPS.",
    Price = 179.99,
    Stock = 45,
    CategoryId = 5
},
new Product
{
    Id = 17,
    Name = "Nerf Elite Blaster",
    Description = "High-performance toy blaster for kids.",
    Price = 39.99,
    Stock = 60,
    CategoryId = 6
},
new Product
{
    Id = 18,
    Name = "Neutrogena Hydro Boost",
    Description = "Hydrating facial moisturizer for dry skin.",
    Price = 24.99,
    Stock = 80,
    CategoryId = 7
},
new Product
{
    Id = 19,
    Name = "Castrol GTX Motor Oil",
    Description = "High-performance motor oil for engines.",
    Price = 29.99,
    Stock = 100,
    CategoryId = 8
},
new Product
{
    Id = 20,
    Name = "Staples Office Chair",
    Description = "Ergonomic office chair for maximum comfort.",
    Price = 149.99,
    Stock = 30,
    CategoryId = 9
}

);
}
}
