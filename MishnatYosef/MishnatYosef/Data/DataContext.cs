namespace MishnatYosef.Data
{
    public class DataContext
    {
        public List<Entities.Customer> _CustomerList { get; set; }
        public List<Entities.DistibutionStation> _StationsList { get; set; }
        public List<Entities.Order> _OrdersList { get; set; }
        public List<Entities.OrderedProduct> _OrderedProductsList { get; set; }
        public List<Entities.Product> _ProductsList { get; set; }
        public List<Entities.ProductOnSell> _ProductsOnSellList { get; set; }
        public List<Entities.Sell> _SellsList { get; set; }

        public DataContext()
        {
            _CustomerList = new List<Entities.Customer>() { new Entities.Customer {Id=1,FirstName="Brachi" } };
            _OrderedProductsList = new List<Entities.OrderedProduct>();
            _OrdersList = new List<Entities.Order>();
            _ProductsList = new List<Entities.Product>();
            _ProductsOnSellList = new List<Entities.ProductOnSell>();
            _SellsList = new List<Entities.Sell>();
            _StationsList = new List<Entities.DistibutionStation>();
        }
    }
}
