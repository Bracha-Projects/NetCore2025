using MishnatYosef.Data;
using MishnatYosef.Entities;

namespace MishnatYosef.Services
{
    public class CustomerService
    {
        readonly IDataContext _dataContext;
        public CustomerService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Entities.Customer> GetService()
        {
            var data = _dataContext.LoadData();
            if (data == null)
                return null;
            return data;
        }
        public Entities.Customer GetByIdService(int id)
        {
            var data = _dataContext.LoadData();
            if (data == null)
                return null;
            return data.Where(c => c.Id == id).FirstOrDefault();
        }
        public bool AddCustomer(Entities.Customer customer)
        {
            var data=_dataContext.LoadData();
            if (data == null) return false;
            data.Add(customer);
            _dataContext.SaveData(data);
            return true;
        }
        public bool DeleteByIdService(int id)
        {
            var data= _dataContext.LoadData();
            var customer = data.Find(c => c.Id == id);
            if (customer == null) return false;
            data.Remove(customer);
            _dataContext.SaveData(data);
            return true;
        }
        public bool UpdateCustomer(int id,Entities.Customer c)
        {
            var data = _dataContext.LoadData();
            int customer = data.FindIndex(x => x.Id == id);
            if (customer == null) return false;             
            data[customer]=c;
            _dataContext.SaveData(data);
            return true;
        }

    }
}
