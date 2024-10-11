using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using ProductsAPI.Seeders;

namespace ProductsAPI.Data;
public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        CategorySeeder.Seed(modelBuilder);
    }
}
