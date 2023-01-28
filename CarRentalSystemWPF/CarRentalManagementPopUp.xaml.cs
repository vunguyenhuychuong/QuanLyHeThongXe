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

namespace VuNguyenHuyChuongWPF
{
    /// <summary>
    /// Interaction logic for CarRentalManagementPopUp.xaml
    /// </summary>
    public partial class CarRentalManagementPopUp : Window
    {
        private string _carId, _customerId;
        private bool _isAddOrUpdate;
        private ICarRentalRepository _carRentalRepository = new CarRentalRepository();
        CarRentalManagement _carRentalManagement;

        public CarRentalManagementPopUp(string carId, string customerId, CarRentalManagement carRentalManagement)
        {   
            _carId = carId;
            _customerId = customerId;
            _isAddOrUpdate = false;
            InitializeComponent();
            SetUpdateForm();
        }

        public CarRentalManagementPopUp(string customerId, CarRentalManagement carRentalManagement)
        {
            _customerId = customerId;
            _isAddOrUpdate = true;
            _carRentalManagement= carRentalManagement;
            InitializeComponent();
            SetAddForm();
        }

        private void SetAddForm()
        {
            try
            {
                txtCustomerId.Text = _customerId.ToString();
                txtCarId.IsEnabled = false;
                txtCarId.IsEnabled = true;
                btnAdd_Update.Content = "Add";
                lbAdd_Update.Content = "Add";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private CarRental GetCarRental()
        {
            return new CarRental
            {
                CustomerId = txtCustomerId.Text,
                CarId = txtCarId.Text,
                PickupDate = DateTime.Parse(txtPickupDate.Text),
                ReturnDate = DateTime.Parse(txtReturnDate.Text),
                RentPrice = decimal.Parse(txtRentPrice.Text)
            };
        }

        private void btnAdd_Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_isAddOrUpdate)
                {
                    _carRentalRepository.InsertCarRental(GetCarRental());
                }
                else
                {
                    _carRentalRepository.UpdateCarRental(GetCarRental());
                }
                _carRentalManagement.LoadCarRentalList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetUpdateForm()
        {
            try
            {
                var carRental = _carRentalRepository.GetCarRental(_carId, _customerId);
                txtCustomerId.IsEnabled = false;
                txtCarId.IsEnabled = false;
                txtPickupDate.Text = carRental.PickupDate.ToString();
                txtReturnDate.Text = carRental.ReturnDate.ToString();
                txtRentPrice.Text = carRental.RentPrice.ToString();
                lbAdd_Update.Content = "Update";
                btnAdd_Update.Content = "Update";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
