using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        Customer LoginByCustomerAccount(String email, String password);
        IEnumerable<Review> ViewRentingHistory(String customerID);
        List<Customer> GetCustomers();
        Customer GetCustomerByID(String carId);
        Customer GetCustomerByEmail(string customerEmail);
        void InsertCustomer(Customer customer);
        void DeleteCustomer(string customerId);
        void UpdateCustomer(Customer customer);
    }
}
