using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Product> GetAllProducts()
        {
            return _dataContext.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            var result = _dataContext.Products.ToList().Find(p => p.Id == id);
            return result;
        }
        public bool AddProductToList(Product product)
        {
            _dataContext.Products.Add(product);
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
        public bool UpdateProduct(Product product, int id)
        {
            var result = _dataContext.Products.ToList().FindIndex(c => c.Id == id);
            if (result == -1)
            {
                return false;
            }
            List<Product> lst = _dataContext.Products.ToList();
            if (product.ProductName != null && product.ProductName != "")
                lst[result].ProductName = product.ProductName;
            if (product.Image!=0)
                lst[result].Image = product.Image;
            if (product.Description != null && product.Description!="")
                lst[result].Description = product.Description;
            if (product.Comments != null && product.Comments != "")
                lst[result].Comments = product.Comments;
            if (product.Category != 0)
                lst[result].Category = product.Category;
            if (product.Price != 0)
                lst[result].Price = product.Price;
            return true;
        }
    }
}
