using ProductService.Models;
using ProductService.Models.DTOs;

namespace ProductService.Services.IServices
{
    public interface IProduct
    {
        Task<string> AddNewProduct(Product newProduct);

        Task<Product> GetProductById(Guid ProductId);

        Task<Product> SearchForProductByName(string productName);

        Task<string> UpdateProduct();

        Task<string> DeleteProduct(Product product);
    }
}
