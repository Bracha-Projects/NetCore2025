using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomers();
        public Customer GetCustomerById(int id);
        public bool AddCustomerToList(Customer customer);
        public bool RemoveCustomerById(int id);
        public bool UpdateCustomer(Customer customer,int id);




    }
}
