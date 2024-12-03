using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class ProductOnSellService:IProductOnSellService
    {
        readonly IProductOnSellRepository _productsOnSellRepository;
        public ProductOnSellService(IProductOnSellRepository productsOnSellRepository)
        {
            _productsOnSellRepository = productsOnSellRepository;
        }
        public List<ProductOnSell> GetService()
        {
            return _productsOnSellRepository.GetAllProductsOnSell();
        }
        public ProductOnSell GetByIdService(int id)
        {
           return _productsOnSellRepository.GetProductById(id); 
        }
        public bool AddProductToSell(ProductOnSell product)
        {
           return _productsOnSellRepository.AddProductToList(product);
        }
        public bool DeleteByIdService(int id)
        {
            return _productsOnSellRepository.RemoveProductById(id);
        }
        public bool UpdateProductOnSell(int id, ProductOnSell p)
        {
            return _productsOnSellRepository.UpdateProductOnSell(p,id);
        }
    }
}
