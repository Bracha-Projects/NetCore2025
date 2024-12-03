using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class OrderedProductRepository:IOrderedProductRepository
    {
        readonly DataContext _dataContext;

        public OrderedProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<OrderedProduct> GetAllOrderedProducts()
        {
            return _dataContext.OrderedProducts;
        }
        public OrderedProduct GetOrderedProductById(int id)
        {
            var result = _dataContext.OrderedProducts.FirstOrDefault(x => x.Id == id);
            return result;
        }
        public bool AddProductTolist(OrderedProduct product)
        {
            try
            {
                _dataContext.OrderedProducts.Add(product);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RemoveProductById(int id)
        {
            try
            {
                var result = _dataContext.OrderedProducts.FirstOrDefault(c => c.Id == id);
                if (result == null)
                {
                    return false;
                }
                _dataContext.OrderedProducts.Remove(result);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateProduct(OrderedProduct product,int id)
        {
            try
            {
                var result = _dataContext.OrderedProducts.FindIndex(c => c.Id == id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.OrderedProducts[result] = product;
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
