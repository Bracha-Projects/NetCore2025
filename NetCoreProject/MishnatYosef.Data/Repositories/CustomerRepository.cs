using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Customer> GetAllCustomers()
        {
            return _dataContext.Customers;
        }
        public Customer GetCustomerById(int id)
        {
            return _dataContext.Customers.FirstOrDefault(c => c.Id == id);
        }
        public bool AddCustomerToList(Customer customer)
        {
            try
            {
                if (!_dataContext.Customers.Contains(customer))
                    _dataContext.Customers.Add(customer);
                else return false;
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RemoveCustomerById(int id)
        {
            try
            {
                var customer = _dataContext.Customers.FirstOrDefault(c => c.Id == id);
                if (customer == null)
                {
                    return false;
                }
                _dataContext.Customers.Remove(customer);
                _dataContext.SaveChange();
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
            
        }
        public bool UpdateCustomer(Customer customer,int id)
        {
            try
            {
                var result = _dataContext.Customers.FindIndex(c => c.Id == customer.Id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.Customers[result] = customer;
                _dataContext.SaveChange() ;
                return true;
            }
            catch( Exception ex) 
            {
                return false;
            }
        }
    }
}
