using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> GetAllOrders()
        {
            return _dataContext.Orders.ToList();
        }
        public Order GetOrderById(int id)
        {
            var result = _dataContext.Orders.FirstOrDefault(o => o.Id == id);
            return result;
        }
        public bool AddOrderToList(Order order)
        {
            _dataContext.Orders.Add(order);
            return true;
        }
        public bool RemoveCustomerById(int id)
        {
            var result = _dataContext.Customers.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                return false;
            }
            _dataContext.Customers.Remove(result);
            return true;
        }
        public bool UpdateCustomer(Order order, int id)
        {
            var result = _dataContext.Orders.ToList().FindIndex(c => c.Id == id);
            if (result == -1)
            {
                return false;
            }
            List<Order> lst = _dataContext.Orders.ToList();
            if(order.OrderDate!=null)
                lst[result].OrderDate = order.OrderDate;
            if (order.Customer != 0)
                lst[result].Customer = order.Customer;
            if (order.Comments != null)
                lst[result].Comments = order.Comments;
            if (order.OrderAmount != 0)
                lst[result].OrderAmount = order.OrderAmount;
            if (order.OrderedProduct != 0)
                lst[result].OrderedProduct = order.OrderedProduct;
            if (order.Sell != 0)
                lst[result].Sell = order.Sell;
            return true;
        }
    }
}
