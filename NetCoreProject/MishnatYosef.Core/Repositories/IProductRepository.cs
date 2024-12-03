using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
        public bool AddProductToList(Product product);
        public bool RemoveProductById(int id);
        public bool UpdateProduct(Product product, int id);
    }
}
