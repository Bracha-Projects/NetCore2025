namespace MishnatYosef.Services
{
    public class ProductService
    {
        public List<Entities.Product> GetService()
        {
            return Data.DataContextManager.Lists._ProductsList;
        }
        public Entities.Product GetByIdService(int id)
        {
            Entities.Product product;
            product = Data.DataContextManager.Lists._ProductsList.Find(x => x.Id == id);
            return product;
        }
        public bool AddProduct(Entities.Product product)
        {
            Data.DataContextManager.Lists._ProductsList.Add(product);
            if (Data.DataContextManager.Lists._ProductsList.Find(x => x.Id == product.Id) != null)
                return true;
            return false;
        }
        public bool DeleteByIdService(int id)
        {
            if (Data.DataContextManager.Lists._ProductsList == null) return false;
            Entities.Product product = Data.DataContextManager.Lists._ProductsList.Find(x => x.Id == id);
            if (product == null) return false;
            Data.DataContextManager.Lists._ProductsList.Remove(product);
            return true;
        }
        public bool UpdateProduct(int id, Entities.Product p)
        {
            int product = Data.DataContextManager.Lists._ProductsList.FindIndex(x => x.Id == id);
            if (product == -1) return false;
            Data.DataContextManager.Lists._ProductsList[product]=p;
            return true;
        }
    }
}
