using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}
