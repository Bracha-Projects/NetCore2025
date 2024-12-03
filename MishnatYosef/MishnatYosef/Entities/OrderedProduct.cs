namespace MishnatYosef.Entities
{
    public class OrderedProduct
    {
        public int Id { get; set; }
        public int Product { get; set; }
        public int Order { get; set; }
        public int ProductQuantity { get; set; }

        public OrderedProduct(int id, int product, int order, int productQuantity)
        {
            Id = id;
            Product = product;
            Order = order;
            ProductQuantity = productQuantity;
        }
        public OrderedProduct()
        {
            
        }
    }
}
