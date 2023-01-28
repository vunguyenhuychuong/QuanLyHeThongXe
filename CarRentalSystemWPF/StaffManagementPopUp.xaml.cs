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
    /// Interaction logic for StaffManagementPopUp.xaml
    /// </summary>
    public partial class StaffManagementPopUp : Window
    {
        private bool _isAddOrUpdate;
        private String _staffId;
        IStaffRepository _staffRepository = new StaffRepository();
        AdminWindow _parentForm;
        public StaffManagementPopUp(string staffId)
        {
            _isAddOrUpdate= false;
            _staffId = staffId;
            InitializeComponent();
            CheckAddOrUpdate();
        }

        public StaffManagementPopUp(bool isAddOrUpdate, AdminWindow parentForm)
        {
            _isAddOrUpdate = isAddOrUpdate;
            _parentForm = parentForm;
            InitializeComponent();
            CheckAddOrUpdate();
        }

        public StaffManagementPopUp(string staffId, AdminWindow parentForm)
        {
            _isAddOrUpdate = false;
            _staffId = staffId;
            _parentForm = parentForm;
            InitializeComponent();
            CheckAddOrUpdate();
        }

        private StaffAccount GetStaffInfor()
        {
            StaffAccount info = new StaffAccount
            {   
                
                StaffId = txtStaffId.Text,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Password,
                Role = int.Parse(txtRole.Text)
            };
            return info;
        }

        private void CheckAddOrUpdate()
        {
            txtStaffId.IsEnabled = _isAddOrUpdate;
            if (_isAddOrUpdate)
            {
                lbAdd_Update.Content = "Add";
                btnAdd_Update.Content = "Add";
            }
            else
            {
                var info = _staffRepository.GetStaffByID(_staffId);
                lbAdd_Update.Content = "Update";
                btnAdd_Update.Content = "Update";
                txtEmail.Text = info.Email;
                txtFullName.Text = info.FullName;
                txtStaffId.Text = info.StaffId;
                txtPassword.Password = info.Password;
                txtRole.Text = info.Role.ToString();
            }
        }

        private void btnAdd_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_isAddOrUpdate)
                {
                    _staffRepository.InsertStaff(GetStaffInfor());
                    MessageBox.Show("Add success");
                }
                else
                {
                    _staffRepository.UpdateStaff(GetStaffInfor());
                    MessageBox.Show("Update success");
                }
                if (_parentForm != null)
                {
                    _parentForm.LoadStaffList();
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
    }
}
