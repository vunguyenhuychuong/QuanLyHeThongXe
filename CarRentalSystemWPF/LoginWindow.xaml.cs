using BusinessObject;
using Microsoft.Extensions.Configuration;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarRentalSystemWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private  ICustomerRepository customerRepository;
        private IStaffRepository staffRepository;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private RoleUser LoginByAdminAccount(String email, String password)
        {
            String _email, _password;
            RoleUser roleUser = null;

            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                _email = config["account:defaultAccount:email"];
                _password = config["account:defaultAccount:password"];
            }

            if (email.Equals(_email) && password.Equals(_password))
            {
                roleUser = new RoleUser
                {
                    Email = email,
                    Password = password,
                    Role = "AD"
                };
                return roleUser;
            }
            else
            {
                return null;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            customerRepository = new CustomerRepository();
            staffRepository  = new StaffRepository();
            AdminWindow adminMainWindow;
            String email = txtUsername.Text;
            String password = txtPasword.Password;
            

            if (LoginByAdminAccount(email, password) != null)
            {
                adminMainWindow = new AdminWindow(true);
                adminMainWindow.UserRoleInfo = LoginByAdminAccount(email, password);
                adminMainWindow.Show();
                this.Hide();
            }
            else if(staffRepository.LoginByStaffAccount(email, password) != null)
            {
                var staff = staffRepository.GetStaffByEmail(txtUsername.Text);
                MenuStaffManagement staffInformationView = new MenuStaffManagement(staff.StaffId);
                staffInformationView.Show();
                this.Hide();
            }
            else if (customerRepository.LoginByCustomerAccount(email, password) != null)
            {
                var customer = customerRepository.GetCustomerByEmail(txtUsername.Text);
                MenuCustomerManagement menuCustomerManagement = new MenuCustomerManagement(customer.CustomerId);
                menuCustomerManagement.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
