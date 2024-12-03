using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class OrderedProductService:IOrderedProductService
    {
        readonly IOrderedProductRepository _orderedProductRepository;
        public OrderedProductService(IOrderedProductRepository orderedProductRepository)
        {
            _orderedProductRepository = orderedProductRepository;
        }
        public List<OrderedProduct> GetService()
        {
            return _orderedProductRepository.GetAllOrderedProducts();
        }
        public OrderedProduct GetByIdService(int id)
        {
            return _orderedProductRepository.GetOrderedProductById(id);
        }
        public bool OrderProduct(OrderedProduct orderedProduct)
        {
            _orderedProductRepository.AddProductTolist(orderedProduct);
            return true;
        }
        public bool DeleteByIdService(int id)
        {
            _orderedProductRepository.RemoveProductById(id);
            return true;
        }
        public bool UpdateOrderedProduct(int id, OrderedProduct o)
        {
            _orderedProductRepository.UpdateProduct(o,id);
            return true;
        }
    }
}
