using BusinessObject;
using Repository;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CustomerManagementPopUp.xaml
    /// </summary>
    public partial class CustomerManagementPopUp : Window
    {
        private string _customerId;
        private bool _isAddOrUpdate;
        CustomerManagement _customerManagement;
        CustomerManagement _parentForm;
        ICustomerRepository _customerRepository = new CustomerRepository();
        public CustomerManagementPopUp(bool isAddOrUpdate, CustomerManagement parentForm)
        {   
            _isAddOrUpdate= true;
            _parentForm = parentForm;
            InitializeComponent();
            CheckAddOrUpdate();
        }

        public CustomerManagementPopUp(string customerId)
        {
            _isAddOrUpdate = false;
            _customerId = customerId;
            InitializeComponent();
            CheckAddOrUpdate();
        }

        public CustomerManagementPopUp(string customerId, CustomerManagement parentForm)
        {
            _isAddOrUpdate = false;
            _customerId = customerId;
            _parentForm = parentForm;
            InitializeComponent();
            CheckAddOrUpdate();
        }

        private void CheckAddOrUpdate()
        {
            txtCustomerId.IsEnabled = _isAddOrUpdate;
            if (_isAddOrUpdate)
            {
                lbAdd_Update.Content = "Add";
                btnAdd_Update.Content = "Add";
            }
            else
            {
                var info = _customerRepository.GetCustomerByID(_customerId);
                lbAdd_Update.Content = "Update";
                btnAdd_Update.Content = "Update";
                txtCustomerId.Text = info.CustomerId;
                txtCustomerName.Text = info.CustomerName;
                txtMobile.Text = info.Mobile;
                txtCustomerEmail.Text = info.CustomerEmail;
                txtCustomerPassword.Password = info.CustomerPassword;
                txtIdentityCard.Text = info.IdentityCard;
                txtLicenseNumber.Text = info.LicenceNumber;
                txtLicenseDate.Text = info.LicenceDate.ToString();
            }
        }

        private void btnAdd_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_isAddOrUpdate)
                {
                    _customerRepository.InsertCustomer(GetFormInfo());

                    MessageBox.Show("Add success");
                }
                else
                {
                    _customerRepository.UpdateCustomer(GetFormInfo());
                    MessageBox.Show("Update success");
                }
                if (_parentForm != null)
                {
                    _parentForm.LoadCustomerList();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private Customer GetFormInfo()
        {
            return new Customer
            {
                CustomerId = txtCustomerId.Text,
                CustomerName = txtCustomerName.Text,
                Mobile = txtMobile.Text,
                CustomerEmail = txtCustomerEmail.Text,
                CustomerPassword = txtCustomerPassword.Password,
                IdentityCard = txtIdentityCard.Text,
                LicenceNumber = txtLicenseNumber.Text,
                LicenceDate = DateTime.Parse(txtLicenseDate.Text)
            };
        }
    }
}
