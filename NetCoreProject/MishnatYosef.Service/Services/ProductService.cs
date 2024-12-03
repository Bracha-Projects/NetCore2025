using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class ProductService:IProductService
    {
        readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetService()
        {
            return _productRepository.GetAllProducts();
        }
        public Product GetByIdService(int id)
        {
            return _productRepository.GetProductById(id);
        }
        public bool AddProduct(Product product)
        {
            return _productRepository.AddProductToList(product);
        }
        public bool DeleteByIdService(int id)
        {
           return _productRepository.RemoveProductById(id);
        }
        public bool UpdateProduct(int id,Product p)
        {
            return _productRepository.UpdateProduct(p,id);
        }
    }
}
