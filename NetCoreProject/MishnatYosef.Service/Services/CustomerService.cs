using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class CustomerService:ICustomerService
    {
        readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customRepository)
        {
            _customerRepository = customRepository;
        }
        public List<Customer> GetService()
        {
            return _customerRepository.GetAllCustomers();
        }
        public Customer GetByIdService(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
        public bool AddCustomer(Customer customer)
        {
            if(!customer.Identity.CheckId())
                return false;
            return _customerRepository.AddCustomerToList(customer);
        }
        public bool DeleteByIdService(int id)
        {
           return _customerRepository.RemoveCustomerById(id);
        }
        public bool UpdateCustomer(int id,Customer c)
        {
            if (!c.Identity.CheckId())
                return false;
            if(FindIndex(id) != -1)
                return _customerRepository.UpdateCustomer(c, id);
            return _customerRepository.AddCustomerToList(c);
        }
        private int FindIndex(int id)
        {
            return GetService().FindIndex(c=>c.Id==id);
        }

    }
}
