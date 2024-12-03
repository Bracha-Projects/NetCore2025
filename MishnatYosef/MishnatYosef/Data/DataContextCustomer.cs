using MishnatYosef.Entities;
using System.Text.Json;

namespace MishnatYosef.Data
{
    public class DataContextCustomer : IDataContext
    {
        public List<Customer> LoadData()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory,"Data", "Customers_db.json");
                string jsonString = File.ReadAllText(path);
                var AllCustomers = JsonSerializer.Deserialize<List<Entities.Customer>>(jsonString);// typeof(DataCoins)); ;
                if (AllCustomers == null) { return null; }
                return AllCustomers;
            }
            catch
            {
                return null;
            }
        }

        public bool SaveData(List<Customer> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "Customers_db.json");
                string jsonString = JsonSerializer.Serialize<List<Customer>>(data);
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }

    }
}

