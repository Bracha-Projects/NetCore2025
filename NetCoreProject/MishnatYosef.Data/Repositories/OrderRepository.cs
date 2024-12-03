using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> GetAllOrders()
        {
            return _dataContext.Orders;
        }
        public Order GetOrderById(int id)
        {
            var result = _dataContext.Orders.FirstOrDefault(o => o.Id == id);
            return result;
        }
        public bool AddOrderToList(Order order)
        {
            try
            {
                _dataContext.Orders.Add(order);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RemoveCustomerById(int id)
        {
            try
            {
                var result = _dataContext.Customers.FirstOrDefault(c => c.Id == id);
                if (result == null)
                {
                    return false;
                }
                _dataContext.Customers.Remove(result);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateCustomer(Order order,int id)
        {
            try
            {
                var result = _dataContext.Orders.FindIndex(c => c.Id == id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.Orders[result] = order;
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
