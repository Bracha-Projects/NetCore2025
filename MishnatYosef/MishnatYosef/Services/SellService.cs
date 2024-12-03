
namespace MishnatYosef.Services
{
    public class SellService
    {
        public List<Entities.Sell> GetService()
        {
            return Data.DataContextManager.Lists._SellsList;
        }
        public Entities.Sell GetByIdService(int id)
        {
            Entities.Sell sell;
            sell = Data.DataContextManager.Lists._SellsList.Find(x => x.Id == id);
            return sell;
        }
        public bool AddSell(Entities.Sell sell)
        {
            Data.DataContextManager.Lists._SellsList.Add(sell);
            if (Data.DataContextManager.Lists._SellsList.Find(x => x.Id == sell.Id) != null)
                return true;
            return false;
        }
        public bool DeleteByIdService(int id)
        {
            if (Data.DataContextManager.Lists._SellsList == null) return false;
            Entities.Sell sell = Data.DataContextManager.Lists._SellsList.Find(x => x.Id == id);
            if (sell == null) return false;
            Data.DataContextManager.Lists._SellsList.Remove(sell);
            return true;
        }
        public bool UpdateCustomer(int id, Entities.Sell s)
        {
            int sell = Data.DataContextManager.Lists._SellsList.FindIndex(x => x.Id == id);
            if (sell == -1) return false;
            Data.DataContextManager.Lists._SellsList[sell] = s;
            return true;
        }
    }
}
