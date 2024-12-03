using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface IOrderedProductRepository
    {
        public List<OrderedProduct> GetAllOrderedProducts();
        public OrderedProduct GetOrderedProductById(int id);
        public bool AddProductTolist(OrderedProduct product);
        public bool RemoveProductById(int id);
        public bool UpdateProduct(OrderedProduct product,int id);
    }
}
