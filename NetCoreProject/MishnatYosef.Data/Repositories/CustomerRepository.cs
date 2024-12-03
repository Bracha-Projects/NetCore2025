using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Customer> GetAllCustomers()
        {
            return _dataContext.Customers.ToList();
        }
        public Customer GetCustomerById(int id)
        {
            return _dataContext.Customers.FirstOrDefault(c => c.Id == id);
        }
        public bool AddCustomerToList(Customer customer)
        {
            if (!_dataContext.Customers.Contains(customer))
            {
                _dataContext.Customers.Add(customer);
                return true;
            }
            else return false;
        }
        public bool RemoveCustomerById(int id)
        {
            var customer = _dataContext.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return false;
            }
            _dataContext.Customers.Remove(customer);
            return true;
        }
        public bool UpdateCustomer(Customer customer, int id)
        {
            var result = _dataContext.Customers.ToList().FindIndex(c => c.Id == customer.Id);
            if (result == -1)
            {
                return false;
            }
            List<Customer> lst = _dataContext.Customers.ToList();
            if (customer.Identity!=null)
                lst[result].Identity = customer.Identity;
            if (customer.FirstName != null)
                lst[result].FirstName = customer.FirstName;
            if (customer.LastName != null)
                lst[result].LastName = customer.LastName;
            if (customer.AnotherPhone1 != null)
                lst[result].AnotherPhone1 = customer.AnotherPhone1;
            if (customer.AnotherPhone2 != null)
                lst[result].AnotherPhone2 = customer.AnotherPhone2;
            if (customer.AnotherPhone3 != null)
                lst[result].AnotherPhone3 = customer.AnotherPhone3;
            if (customer.CreditCardValidity != null)
                lst[result].CreditCardValidity = customer.CreditCardValidity;
            if (customer.CreditCardNumber != null)
                lst[result].CreditCardNumber = customer.CreditCardNumber;
            if (customer.Cvv != 0)
                lst[result].Cvv = customer.Cvv;
            if (customer.Email != null)
                lst[result].Email = customer.Email;
            return true;
        }
    }
}
