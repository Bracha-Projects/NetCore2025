namespace MishnatYosef.Services
{
    public class OrderedProductService
    {
        public List<Entities.OrderedProduct> GetService()
        {
            return Data.DataContextManager.Lists._OrderedProductsList;
        }
        public Entities.OrderedProduct GetByIdService(int id)
        {
            Entities.OrderedProduct orderedProduct;
            orderedProduct = Data.DataContextManager.Lists._OrderedProductsList.Find(x => x.Id == id);
            return orderedProduct;
        }
        public bool OrderProduct(Entities.OrderedProduct orderedProduct)
        {
            Data.DataContextManager.Lists._OrderedProductsList.Add(orderedProduct);
            if (Data.DataContextManager.Lists._OrderedProductsList.Find(x => x.Id == orderedProduct.Id) != null)
                return true;
            return false;
        }
        public bool DeleteByIdService(int id)
        {
            if (Data.DataContextManager.Lists._OrderedProductsList == null) return false;
            Entities.OrderedProduct orderedProduct = Data.DataContextManager.Lists._OrderedProductsList.Find(x => x.Id == id);
            if (orderedProduct == null) return false;
            Data.DataContextManager.Lists._OrderedProductsList.Remove(orderedProduct);
            return true;
        }
        public bool UpdateOrderedProduct(int id, Entities.OrderedProduct o)
        {
            int orderedProduct = Data.DataContextManager.Lists._OrderedProductsList.FindIndex(x => x.Id == id);
            if (orderedProduct == -1) return false;
            Data.DataContextManager.Lists._OrderedProductsList[orderedProduct]=o;
            return true;
        }
    }
}
