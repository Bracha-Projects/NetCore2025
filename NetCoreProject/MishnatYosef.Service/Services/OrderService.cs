using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class OrderService:IOrderService
    {
        readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetService()
        {
            return _orderRepository.GetAllOrders();
        }
        public Order GetByIdService(int id)
        {
           return _orderRepository.GetOrderById(id);
        }
        public bool AddOrder(Order order)
        {
            return _orderRepository.AddOrderToList(order);
        }
        public bool DeleteByIdService(int id)
        {
            return _orderRepository.RemoveCustomerById(id);
        }
        public bool UpdateOrder(int id, Order o)
        {
            if(FindIndex(id)!=-1)
                return _orderRepository.UpdateCustomer(o,id);
            return _orderRepository.AddOrderToList(o);
        }
        private int FindIndex(int id)
        {
            return GetService().FindIndex(c => c.Id == id);
        }
    }
}
