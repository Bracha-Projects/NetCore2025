using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface IOrderedProductService
    {
        public List<OrderedProduct> GetService();
        public OrderedProduct GetByIdService(int id);
        public bool OrderProduct(OrderedProduct orderedProduct);
        public bool DeleteByIdService(int id);
        public bool UpdateOrderedProduct(int id, OrderedProduct o);
    }
}
