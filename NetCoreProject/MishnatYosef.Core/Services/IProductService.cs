using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface IProductService
    {
        public List<Product> GetService();
        public Product GetByIdService(int id);
        public bool AddProduct(Product product);
        public bool DeleteByIdService(int id);
        public bool UpdateProduct(int id, Product p);
    }
}
