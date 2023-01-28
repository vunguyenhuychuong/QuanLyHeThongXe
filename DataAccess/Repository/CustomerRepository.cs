using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void DeleteCustomer(string customerId) => CustomerDAO.Instance.DeleteCustomer(customerId);

        public Customer GetCustomerByEmail(string customerEmail) => CustomerDAO.Instance.GetCustomerByEmail(customerEmail);

        public Customer GetCustomerByID(string customerId) => CustomerDAO.Instance.GetCustomerByID(customerId);

        public void InsertCustomer(Customer customer) => CustomerDAO.Instance.InsertCustomer(customer);


        public Customer LoginByCustomerAccount(string email, string password) => CustomerDAO.Instance.LoginByCustomerAccount(email, password);

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);


        public IEnumerable<Review> ViewRentingHistory(string customerID) => CustomerDAO.Instance.ViewRentingHistory(customerID);

        List<Customer> ICustomerRepository.GetCustomers() => CustomerDAO.Instance.GetCustomers();
    }
}
