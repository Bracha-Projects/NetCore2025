using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class OrderedProductRepository : IOrderedProductRepository
    {
        readonly DataContext _dataContext;

        public OrderedProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<OrderedProduct> GetAllOrderedProducts()
        {
            return _dataContext.OrderedProducts.ToList();
        }
        public OrderedProduct GetOrderedProductById(int id)
        {
            var result = _dataContext.OrderedProducts.FirstOrDefault(x => x.Id == id);
            return result;
        }
        public bool AddProductTolist(OrderedProduct product)
        {
            _dataContext.OrderedProducts.Add(product);
            return true;
        }
        public bool RemoveProductById(int id)
        {
            var result = _dataContext.OrderedProducts.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                return false;
            }
            _dataContext.OrderedProducts.Remove(result);
            return true;
        }
        public bool UpdateProduct(OrderedProduct product, int id)
        {
            var result = _dataContext.OrderedProducts.ToList().FindIndex(c => c.Id == id);
            if (result == -1)
            {
                return false;
            }
            List<OrderedProduct> lst = _dataContext.OrderedProducts.ToList();
            if (product.Order !=0)
                lst[result].Order = product.Order;
            if (product.Product != 0)
                lst[result].Product = product.Product;
            if (product.ProductQuantity != 0)
                lst[result].ProductQuantity = product.ProductQuantity;
            return true;
        }
    }
}
