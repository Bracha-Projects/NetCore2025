namespace MishnatYosef.Services
{
    public class OrderService
    {
        public List<Entities.Order> GetService()
        {
            return Data.DataContextManager.Lists._OrdersList;
        }
        public Entities.Order GetByIdService(int id)
        {
            Entities.Order order;
            order = Data.DataContextManager.Lists._OrdersList.Find(x => x.Id == id);
            return order;
        }
        public bool AddOrder(Entities.Order order)
        {
            Data.DataContextManager.Lists._OrdersList.Add(order);
            if (Data.DataContextManager.Lists._OrdersList.Find(x => x.Id ==order.Id ) != null)
                return true;
            return false;
        }
        public bool DeleteByIdService(int id)
        {
            if (Data.DataContextManager.Lists._OrdersList == null) return false;
            Entities.Order order = Data.DataContextManager.Lists._OrdersList.Find(x => x.Id == id);
            if (order == null) return false;
            Data.DataContextManager.Lists._OrdersList.Remove(order);
            return true;
        }
        public bool UpdateOrder(int id, Entities.Order o)
        {
            int order = Data.DataContextManager.Lists._OrdersList.FindIndex(x => x.Id == id);
            if (order == -1) return false;
            Data.DataContextManager.Lists._OrdersList[order]=o;
            return true;
        }
    }
}
