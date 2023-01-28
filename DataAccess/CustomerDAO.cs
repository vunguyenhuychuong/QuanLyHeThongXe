using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static readonly object instanceLock = new object();
        CarRentalSystemDBContext dBContext = new CarRentalSystemDBContext();

        private CustomerDAO() { }

        public static CustomerDAO Instance
        {
            get 
            {
                lock (instanceLock) 
                {
                    if(instance == null) 
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public Customer LoginByCustomerAccount(string email, string password)
        {
            Customer customer = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                customer = context.Customers.SingleOrDefault(c => c.CustomerEmail== email && c.CustomerPassword == password);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }

        public IEnumerable<Review> ViewRentingHistory(String customerID)
        {
            List<Review> listCarRental;
            try
            {
                var context = new CarRentalSystemDBContext();
                listCarRental = context.Reviews.Where(c => c.CustomerId.Contains(customerID)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCarRental;
        }
        public void DeleteCustomer(string customerID)
        {
            if (GetCustomerByID(customerID) != null)
            {
                dBContext.Remove(dBContext.Customers.FirstOrDefault<Customer>(p => p.CustomerId == customerID));
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Invalid ID");
            }
        }
        public Customer GetCustomerByID(string customerId)
        {
            Customer customer = dBContext.Customers.SingleOrDefault<Customer>(p => p.CustomerId == customerId);
            return customer;
        }
        public void InsertCustomer(Customer customer)
        {
            if (GetCustomerByID(customer.CustomerId) == null)
            {
                dBContext.Customers.Add(customer);
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Try another id");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            Customer cus = GetCustomerByID(customer.CustomerId);
            if (cus != null)
            {
                cus.CustomerId = customer.CustomerId;
                cus.CustomerName = customer.CustomerName;
                cus.Mobile = customer.Mobile;
                cus.CustomerEmail = customer.CustomerEmail;
                cus.CustomerPassword = customer.CustomerPassword;
                cus.IdentityCard = customer.IdentityCard;
                cus.LicenceNumber = customer.LicenceNumber;
                cus.LicenceDate = customer.LicenceDate;
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Product does not exitst");
            }
        }

        public List<Customer> GetCustomers() => dBContext.Customers.ToList();

        public Customer GetCustomerByEmail(string customerEmail)
        {
            Customer customer = dBContext.Customers.SingleOrDefault(p => p.CustomerEmail == customerEmail);
            return customer;
        }
    }
}
