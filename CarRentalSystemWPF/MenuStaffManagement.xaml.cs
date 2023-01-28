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
    /// Interaction logic for MenuStaffManagement.xaml
    /// </summary>
    public partial class MenuStaffManagement : Window
    {
        private string _staffId;
        private bool _isAdmin;
        private IStaffRepository staffRepository = new StaffRepository();
        public MenuStaffManagement(string staffId)
        {   
            _staffId = staffId;
            InitializeComponent();
            LoadStaffObject();
        }

        public MenuStaffManagement(bool isAdmin)
        {
            _isAdmin= isAdmin;
            InitializeComponent();
            LoadStaffObject();
        }

        public void LoadStaffObject()
        {
            txtSelectedId.Text = _staffId;
        }

        private void btnMemberManagement_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                StaffManagementPopUp memberManagementPopup = new StaffManagementPopUp(txtSelectedId.Text);
                memberManagementPopup.Show();
            }
            else
            {
                MessageBox.Show("Please select a member");
            }
        }

        private void btnCarManagement_Click(object sender, RoutedEventArgs e)
        {
            CarManagement carManagement = new CarManagement();
            carManagement.Show();
        }

        private void btnCustomerManagement_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerManagement  = new CustomerManagement();
            customerManagement.Show();
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
