using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface IProductOnSellRepository
    {
        public List<ProductOnSell> GetAllProductsOnSell();
        public ProductOnSell GetProductById(int id);
        public bool AddProductToList(ProductOnSell product);
        public bool RemoveProductById(int id);
        public bool UpdateProductOnSell(ProductOnSell product,int id);
    }
}
