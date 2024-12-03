using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface IOrderService
    {
        public List<Order> GetService();
        public Order GetByIdService(int id);
        public bool AddOrder(Order order);
        public bool DeleteByIdService(int id);
        public bool UpdateOrder(int id, Order o);
    }
}
