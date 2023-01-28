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
    /// Interaction logic for MenuCustomerManagement.xaml
    /// </summary>
    public partial class MenuCustomerManagement : Window
    {
        private string _customerId;
        public MenuCustomerManagement()
        {
            InitializeComponent();
        }

        public MenuCustomerManagement(string customerId)
        {   
            _customerId = customerId;
            InitializeComponent();
            LoadStaffObject();
        }

        public void LoadStaffObject()
        {
            txtSelectedId.Text = _customerId;
        }

        private void btnCustomerManagement_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                CustomerManagementPopUp customerManagementPopup = new CustomerManagementPopUp(txtSelectedId.Text);
                customerManagementPopup.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer");
            }
        }

        private void btnViewRentingHistory_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                ViewRentingHistory viewRentingHistory = new ViewRentingHistory(txtSelectedId.Text);
                viewRentingHistory.Show();
            }
            else
            {
                MessageBox.Show("Please select a member");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtSelectedId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
