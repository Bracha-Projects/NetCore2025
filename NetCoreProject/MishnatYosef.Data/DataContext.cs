
using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MishnatYosef.Data
{
    public class DataContext
    {
        public List<Customer> Customers { get; set; }
        public List<DistibutionStation> DistributionStations { get; set; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<OrderedProduct> OrderedProducts { get; set; }
        public List<ProductOnSell> ProductsOnSell { get; set; }
        public List<Sell> Sells { get; set; }

        public DataContext()
        {
            string path1 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Customers_db.json");
            string path2 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Stations_db.json");
            string path3 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Sell_db.json");
            string path4 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Products_db.json");
            string path5 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "ProductOnSell_db.json");
            string path6 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "OrderedProduct.json"); 
            Customers = JsonSerializer.Deserialize<List<Customer>>(File.ReadAllText(path1));
            DistributionStations = JsonSerializer.Deserialize<List<DistibutionStation>>(File.ReadAllText(path2));
            Orders = new List<Order>();
            Products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(path4));
            OrderedProducts = JsonSerializer.Deserialize<List<OrderedProduct>>(File.ReadAllText(path6));
            ProductsOnSell = JsonSerializer.Deserialize<List<ProductOnSell>>(File.ReadAllText(path5));
            Sells = JsonSerializer.Deserialize<List<Sell>>(File.ReadAllText(path3));
        }

        public void SaveChange()
        {

            string path1 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Customers_db.json");
            string path2 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Stations_db.json");
            string path3 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Sell_db.json");
            string path4 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "Products_db.json");
            string path5 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "ProductOnSell_db.json");
            string path6 = Path.Combine("C:\\Users\\Yoga\\Documents\\MishnatYosef\\MishnatYosef.Data\\Data", "OrderedProduct.json");
            string jsonString1 = JsonSerializer.Serialize<List<Customer>>(Customers);
            string jsonString2 = JsonSerializer.Serialize<List<DistibutionStation>>(DistributionStations);
            string jsonString3 = JsonSerializer.Serialize<List<Order>>(Orders);
            string jsonString4 = JsonSerializer.Serialize<List<Product>>(Products);
            string jsonString5 = JsonSerializer.Serialize<List<OrderedProduct>>(OrderedProducts);
            string jsonString6 = JsonSerializer.Serialize<List<ProductOnSell>>(ProductsOnSell);
            string jsonString7 = JsonSerializer.Serialize<List<Sell>>(Sells);
            File.WriteAllText(path1, jsonString1);
            File.WriteAllText(path2, jsonString2);
            //File.WriteAllText(path, jsonString3);
            File.WriteAllText(path4, jsonString4);
            File.WriteAllText(path6, jsonString5);
            File.WriteAllText(path5, jsonString6);
            File.WriteAllText(path3, jsonString7);

        }

    }
}
