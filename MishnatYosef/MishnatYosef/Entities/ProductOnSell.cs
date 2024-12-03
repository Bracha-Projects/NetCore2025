namespace MishnatYosef.Entities
{
    public class ProductOnSell
    {
        public int Id { get; set; }
        public int Sell { get; set; }
        public int Product { get; set; }
        public int QuantityInStock { get; set; }

        public ProductOnSell(int id, int sell, int product, int quantityInStock)
        {
            Id = id;
            Sell = sell;
            Product = product;
            QuantityInStock = quantityInStock;
        }
        public ProductOnSell()
        {
            
        }
    }
}
