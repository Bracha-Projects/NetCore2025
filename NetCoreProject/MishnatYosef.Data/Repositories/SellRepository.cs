using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class SellRepository : ISellRepository
    {
        readonly DataContext _dataContext;
        public SellRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Sell> GetAllSells()
        {
            return _dataContext.Sells.ToList();
        }
        public Sell GetSellById(int id)
        {
            var result = _dataContext.Sells.FirstOrDefault(s => s.Id == id);
            return result;
        }
        public bool AddSellToList(Sell sell)
        {
            _dataContext.Sells.Add(sell);
            return true;
        }
        public bool RemoveSellById(int id)
        {
            var result = _dataContext.Customers.FirstOrDefault(c => c.Id == id);
            if (result == null)
            {
                return false;
            }
            _dataContext.Customers.Remove(result);
            return true;
        }
        public bool UpdateSell(Sell sell, int id)
        {
            var result = _dataContext.Sells.ToList().FindIndex(c => c.Id == id);
            if (result == -1)
            {
                return false;
            }
            List<Sell> lst = _dataContext.Sells.ToList();
            if(sell.Type !=0)
                lst[result].Type = sell.Type;
            if (sell.SellHours != null && sell.SellHours!="")
                lst[result].SellHours = sell.SellHours;
            if (sell.Station != 0)
                lst[result].Station = sell.Station;
            if (sell.ClosingTime != null)
                lst[result].ClosingTime = sell.ClosingTime;
            return true;
        }
    }
}
