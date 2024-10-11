using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data;
using ProductsAPI.Models;
using ProductsAPI.Repositories;

namespace ProductsAPI.Services;
public class ProductServices : IProductRepository
{
    protected readonly AppDbContext _context;

    public ProductServices(AppDbContext context)
    {
        _context = context;
    }

    public async Task Create(Product product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product), "product cannot be null");
        }
        try
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Failed to add product into the database", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Unexpected error adding the product", ex);
        }
    }

    public async Task Delete(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product), "product not found");
        }
        else
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        if (!_context.Products.Any())
        {
            throw new InvalidOperationException("Products not found in the database.");
        }
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        return product;
    }

    public async Task Update(Product product)
    {
        if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "product cannot be null");
            }
            try
            {
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception("Failed to update product in the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error updating the product", ex);
            }
    }
}
