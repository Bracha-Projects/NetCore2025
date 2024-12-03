namespace MishnatYosef.Data
{
    public interface IDataContext
    {
        public List<Entities.Customer> LoadData();
        public bool SaveData(List<Entities.Customer> data);
    }
}
