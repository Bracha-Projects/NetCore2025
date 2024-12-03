using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface ICustomerService
    {
        public List<Customer> GetService();
        public Customer GetByIdService(int id);
        public bool AddCustomer(Customer customer);
        public bool DeleteByIdService(int id);
        public bool UpdateCustomer(int id, Customer c);
    }
}
