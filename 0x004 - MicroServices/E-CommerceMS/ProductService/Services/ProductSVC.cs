using ProductService.Models;
using ProductService.Models.DTOs;
using ProductService.Services.IServices;

namespace ProductService.Services
{
    public class ProductSVC : IProduct
    {
        Task<string> IProduct.AddNewProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        Task<string> IProduct.DeleteProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        Task<Product> IProduct.GetProductById(Guid ProductId)
        {
            throw new NotImplementedException();
        }

        Task<ProductDTO> IProduct.SearchForProductByName(GetProductDTO productName)
        {
            throw new NotImplementedException();
        }

        Task<string> IProduct.UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
