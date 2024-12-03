using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface IProductOnSellService
    {
        public List<ProductOnSell> GetService();
        public ProductOnSell GetByIdService(int id);
        public bool AddProductToSell(ProductOnSell product);
        public bool DeleteByIdService(int id);
        public bool UpdateProductOnSell(int id, ProductOnSell p);
    }
}
