using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface ISellRepository
    {
        public List<Sell> GetAllSells();
        public Sell GetSellById(int id);
        public bool AddSellToList(Sell sell);
        public bool RemoveSellById(int id);
        public bool UpdateSell(Sell sell, int id);
    }
}
