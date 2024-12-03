using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class ProductRepository:IProductRepository
    {
        readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Product> GetAllProducts()
        {
            return _dataContext.Products;
        }
        public Product GetProductById(int id)
        {
            var result = _dataContext.Products.Find(p=>p.Id==id);
            return result;
        }
        public bool AddProductToList(Product product)
        {
            try
            {
                _dataContext.Products.Add(product);
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
        public bool UpdateProduct(Product product,int id)
        {
            try
            {
                var result = _dataContext.Products.FindIndex(c => c.Id == id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.Products[result] = product;
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
