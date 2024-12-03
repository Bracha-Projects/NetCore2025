namespace MishnatYosef.Data
{
    public class CustomersFakeData:IDataContext
    {
        public List<Entities.Customer> LoadData()

        {
            List<Entities.Customer> data = new List<Entities.Customer>();
            data.Add(new Entities.Customer() { Id=1,Email="b403177@gmail.com",FirstName="brachi"});
            data.Add(new Entities.Customer() { Id = 2, Email = "b0548403177@gmail.com", FirstName = "b-b" });
            return data;
        }

        public bool SaveData(List<Entities.Customer> data)
        {
            return true;
        }
    }
}
