using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class ProductOnSellRepository:IProductOnSellRepository
    {
        readonly DataContext _dataContext;

        public ProductOnSellRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ProductOnSell> GetAllProductsOnSell()
        {
            return _dataContext.ProductsOnSell;
        }
        public ProductOnSell GetProductById(int id)
        {
            var result = _dataContext.ProductsOnSell.FirstOrDefault(x => x.Id == id);
            return result;
        }
        public bool AddProductToList(ProductOnSell product)
        {
            try
            {
                _dataContext.ProductsOnSell.Add(product);
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
        public bool UpdateProductOnSell(ProductOnSell product,int id)
        {
            try
            {
                var result = _dataContext.ProductsOnSell.FindIndex(c => c.Id == id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.ProductsOnSell[result] = product;
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
