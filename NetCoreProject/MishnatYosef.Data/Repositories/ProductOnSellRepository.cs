using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class ProductOnSellRepository : IProductOnSellRepository
    {
        readonly DataContext _dataContext;

        public ProductOnSellRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ProductOnSell> GetAllProductsOnSell()
        {
            return _dataContext.ProductsOnSell.ToList();
        }
        public ProductOnSell GetProductById(int id)
        {
            var result = _dataContext.ProductsOnSell.FirstOrDefault(x => x.Id == id);
            return result;
        }
        public bool AddProductToList(ProductOnSell product)
        {
            _dataContext.ProductsOnSell.Add(product);
            return true;
        }
        public bool RemoveProductById(int id)
        {
            var result = _dataContext.Customers.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                return false;
            }
            _dataContext.Customers.Remove(result);
            return true;
        }
        public bool UpdateProductOnSell(ProductOnSell product, int id)
        {
            var result = _dataContext.ProductsOnSell.ToList().FindIndex(c => c.Id == id);
            if (result == -1)
            {
                return false;
            }
            List<ProductOnSell> lst = _dataContext.ProductsOnSell.ToList();
            if(product.Sell!=0)
                lst[result].Sell = product.Sell;
            if (product.Product != 0)
                lst[result].Product = product.Product;
            if (product.QuantityInStock != 0)
                lst[result].QuantityInStock = product.QuantityInStock;
            return true;
        }
    }
}
