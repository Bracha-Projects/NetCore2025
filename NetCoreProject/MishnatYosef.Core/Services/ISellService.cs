using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface ISellService
    {
        public List<Sell> GetService();
        public Sell GetByIdService(int id);
        public bool AddSell(Sell sell);
        public bool DeleteByIdService(int id);
        public bool UpdateCustomer(int id, Sell s);
    }
}
