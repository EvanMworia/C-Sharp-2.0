using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Models;
using ProductService.Models.DTOs;
using ProductService.Services.IServices;

namespace ProductService.Services
{
    public class ProductSVC : IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductSVC(ApplicationDbContext Context)
        {
               _context = Context;
        }
        public async Task<string> AddNewProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();
            return "PRODUCT HAS BEEN ADDED SUCCESFULLY";
        }

        public async Task<string> DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return "PRODUCT HAS BEEN DELETED";
        }

        public async Task<Product> GetProductById(Guid ProductId)
        {
            return  await _context.Products.Where(x => x.ProductId == ProductId).FirstOrDefaultAsync();
        }

        public async Task<Product> SearchForProductByName(string productName)
        {
            return await _context.Products.Where(x => x.Name == productName).FirstOrDefaultAsync();
        }

        public async Task<string> UpdateProduct()
        {
            await _context.SaveChangesAsync();
            return "UPDATES HAVE BEEN APPLIED SUCCESSFULLY";
        }
    }
}
