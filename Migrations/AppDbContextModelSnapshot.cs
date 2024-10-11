﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsAPI.Data;

#nullable disable

namespace ProductsAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ProductsAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "All electronic products.",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Description = "All clothing products.",
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "All books products.",
                            Name = "Books"
                        },
                        new
                        {
                            Id = 4,
                            Description = "All home and garden products.",
                            Name = "Home & Garden"
                        },
                        new
                        {
                            Id = 5,
                            Description = "All sports and outdoor products.",
                            Name = "Sports & Outdoors"
                        },
                        new
                        {
                            Id = 6,
                            Description = "All toys and games products.",
                            Name = "Toys & Games"
                        },
                        new
                        {
                            Id = 7,
                            Description = "All health and beauty products.",
                            Name = "Health & Beauty"
                        },
                        new
                        {
                            Id = 8,
                            Description = "All automotive products.",
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = 9,
                            Description = "All office supplies products.",
                            Name = "Office Supplies"
                        },
                        new
                        {
                            Id = 10,
                            Description = "All cooking supplies.",
                            Name = "Cooking"
                        });
                });

            modelBuilder.Entity("ProductsAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "The latest Samsung Galaxy S21 from Samsung.",
                            Name = "Samsung Galaxy S21 Ultra",
                            Price = 999.99000000000001,
                            Stock = 4
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "The latest Apple iPhone 12 Pro Max from Apple.",
                            Name = "Apple iPhone 12 Pro Max",
                            Price = 1299.99,
                            Stock = 10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "The latest Nike Air Max 97 from Nike.",
                            Name = "Nike Air Max 97",
                            Price = 149.99000000000001,
                            Stock = 20
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "A philosophical novel by Paulo Coelho.",
                            Name = "The Alchemist",
                            Price = 19.989999999999998,
                            Stock = 50
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "High-performance vacuum cleaner for home use.",
                            Name = "Dyson V11 Vacuum Cleaner",
                            Price = 599.99000000000001,
                            Stock = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            Description = "Professional-grade tennis racket for sports enthusiasts.",
                            Name = "Wilson Tennis Racket",
                            Price = 199.99000000000001,
                            Stock = 15
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 6,
                            Description = "Detailed Lego set of the Millennium Falcon.",
                            Name = "Lego Star Wars Millennium Falcon",
                            Price = 149.99000000000001,
                            Stock = 30
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 7,
                            Description = "Advanced electric toothbrush for dental care.",
                            Name = "Oral-B Electric Toothbrush",
                            Price = 89.989999999999995,
                            Stock = 100
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 8,
                            Description = "Durable and high-performance tires for all seasons.",
                            Name = "Michelin All-Season Tires",
                            Price = 129.99000000000001,
                            Stock = 25
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 9,
                            Description = "All-in-one wireless printer for office use.",
                            Name = "HP OfficeJet Pro Printer",
                            Price = 199.99000000000001,
                            Stock = 8
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 10,
                            Description = "7-in-1 electric pressure cooker for quick meals.",
                            Name = "Instant Pot Duo",
                            Price = 89.989999999999995,
                            Stock = 35
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Description = "Noise-canceling over-ear headphones for music lovers.",
                            Name = "Sony WH-1000XM4 Headphones",
                            Price = 349.99000000000001,
                            Stock = 20
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "High-performance running shoes for athletes.",
                            Name = "Adidas Ultraboost 21",
                            Price = 180.0,
                            Stock = 60
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "A bestselling self-improvement book by James Clear.",
                            Name = "Atomic Habits",
                            Price = 24.989999999999998,
                            Stock = 40
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "Compact gas grill for outdoor cooking.",
                            Name = "Weber Spirit Gas Grill",
                            Price = 499.99000000000001,
                            Stock = 12
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Description = "Advanced fitness tracker with GPS.",
                            Name = "Fitbit Charge 5",
                            Price = 179.99000000000001,
                            Stock = 45
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 6,
                            Description = "High-performance toy blaster for kids.",
                            Name = "Nerf Elite Blaster",
                            Price = 39.990000000000002,
                            Stock = 60
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 7,
                            Description = "Hydrating facial moisturizer for dry skin.",
                            Name = "Neutrogena Hydro Boost",
                            Price = 24.989999999999998,
                            Stock = 80
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 8,
                            Description = "High-performance motor oil for engines.",
                            Name = "Castrol GTX Motor Oil",
                            Price = 29.989999999999998,
                            Stock = 100
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 9,
                            Description = "Ergonomic office chair for maximum comfort.",
                            Name = "Staples Office Chair",
                            Price = 149.99000000000001,
                            Stock = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
