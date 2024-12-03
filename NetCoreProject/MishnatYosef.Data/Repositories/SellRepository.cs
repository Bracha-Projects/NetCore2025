using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class SellRepository:ISellRepository
    {
        readonly DataContext _dataContext;
        public SellRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Sell> GetAllSells()
        {
            return _dataContext.Sells;
        }
        public Sell GetSellById(int id)
        {
            var result = _dataContext.Sells.FirstOrDefault(s => s.Id == id);
            return result;
        }
        public bool AddSellToList(Sell sell)
        {
            try
            {
                _dataContext.Sells.Add(sell);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RemoveSellById(int id)
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
        public bool UpdateSell(Sell sell,int id)
        {
            try
            {
                var result = _dataContext.Sells.FindIndex(c => c.Id == id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.Sells[result] = sell;
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
