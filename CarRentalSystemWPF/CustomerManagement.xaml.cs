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
using VuNguyenHuyChuongWPF;

namespace CarRentalSystemWPF
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        ICustomerRepository customerRepository = new CustomerRepository();

        public CustomerManagement()
        {
            InitializeComponent();
            LoadCustomerList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagementPopUp customerManagementPopup = new CustomerManagementPopUp(true, this);
            customerManagementPopup.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                CustomerManagementPopUp customerManagementPopup = new CustomerManagementPopUp(txtSelectedId.Text, this);
                customerManagementPopup.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                MessageBox.Show("Please select the customer you want to delete");
            }
            else
            {
                MessageBoxResult dialogResult = MessageBox.Show("This action can't be reversed", "Are you sure?", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    customerRepository.DeleteCustomer(txtSelectedId.Text);
                    LoadCustomerList();
                }
            }
        }

        public void LoadCustomerList()
        {
            lsvCustomer.ItemsSource = customerRepository.GetCustomers();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lsvCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCarRental_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtSelectedId.Text))
                {
                    CarRentalManagement carRentalManagement = new CarRentalManagement(txtSelectedId.Text);
                    carRentalManagement.Show();
                }
                else
                {
                    throw new Exception("Please select an order");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
