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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {   
        private IStaffRepository staffRepository = new StaffRepository();
        public RoleUser UserRoleInfo { get; set; }
        private bool _isAdmin;
        private string _staffId;
        public AdminWindow(bool isAdmin)
        {
            _isAdmin = isAdmin;
            InitializeComponent();
            LoadStaffList();
        }

        public AdminWindow(string staffId)
        {
            _isAdmin = false;
            _staffId = staffId;
            InitializeComponent();
            LoadStaffList();
        }

        public void LoadStaffList()
        {
            lsvStaff.ItemsSource = staffRepository.GetStaffAccounts();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StaffManagementPopUp staffManagementPopup = new StaffManagementPopUp(true, this);
            staffManagementPopup.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                StaffManagementPopUp memberManagementPopup = new StaffManagementPopUp(txtSelectedId.Text, this);
                memberManagementPopup.Show();
            }
            else
            {
                MessageBox.Show("Please select a member");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                MessageBoxResult dialogResult = MessageBox.Show("This action can't be reversed", "Are you sure?", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    staffRepository.DeleteStaff(txtSelectedId.Text);
                    LoadStaffList();
                }
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

        private void lsvStaffs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
