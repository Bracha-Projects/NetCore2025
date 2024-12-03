namespace MishnatYosef.Services
{
    public class ProductOnSellService
    {
        public List<Entities.ProductOnSell> GetService()
        {
            return Data.DataContextManager.Lists._ProductsOnSellList;
        }
        public Entities.ProductOnSell GetByIdService(int id)
        {
            Entities.ProductOnSell product;
            product = Data.DataContextManager.Lists._ProductsOnSellList.Find(x => x.Id == id);
            return product;
        }
        public bool AddProductToSell(Entities.ProductOnSell product)
        {
            Data.DataContextManager.Lists._ProductsOnSellList.Add(product);
            if (Data.DataContextManager.Lists._ProductsOnSellList.Find(x => x.Id == product.Id) != null)
                return true;
            return false;
        }
        public bool DeleteByIdService(int id)
        {
            if (Data.DataContextManager.Lists._ProductsOnSellList == null) return false;
            Entities.ProductOnSell product = Data.DataContextManager.Lists._ProductsOnSellList.Find(x => x.Id == id);
            if (product == null) return false;
            Data.DataContextManager.Lists._ProductsOnSellList.Remove(product);
            return true;
        }
        public bool UpdateProductOnSell(int id, Entities.ProductOnSell p)
        {
            int product = Data.DataContextManager.Lists._ProductsOnSellList.FindIndex(x => x.Id == id);
            if (product == -1) return false;
            Data.DataContextManager.Lists._ProductsOnSellList[product]=p;
            return true;
        }
    }
}
