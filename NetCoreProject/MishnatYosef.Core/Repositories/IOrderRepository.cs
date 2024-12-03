using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface IOrderRepository
    {
        public List<Order> GetAllOrders();
        public Order GetOrderById(int id);
        public bool AddOrderToList(Order order);
        public bool RemoveCustomerById(int id);
        public bool UpdateCustomer(Order order, int id);
    }
}
