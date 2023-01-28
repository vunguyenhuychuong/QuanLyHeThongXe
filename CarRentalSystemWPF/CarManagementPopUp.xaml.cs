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
    /// Interaction logic for CarManagementPopUp.xaml
    /// </summary>
    public partial class CarManagementPopUp : Window
    {
        private string _carId;
        private bool _isAddOrUpdate;
        CarManagement _carManagement;
        ICarRepository carRepository = new CarRepository();
        public CarManagementPopUp(CarManagement carManagement)
        {   
            _isAddOrUpdate= true;
            _carManagement = carManagement;
            InitializeComponent();
            lbAdd_Update.Content = "Add";
            btnAdd_Update.Content = "Add";
        }

        public CarManagementPopUp(bool isAdmin , string carId)
        {
            _isAddOrUpdate = true;
           _isAddOrUpdate= isAdmin;
            InitializeComponent();
            SetUpdateForm(carId);
        }

        private void SetUpdateForm(string carId)
        {
            try
            {
                lbAdd_Update.Content = "Update";
                btnAdd_Update.Content = "Update";
                var car = carRepository.GetCarByID(carId);
                txtCarId.Text = car.CarId;
                txtCarName.Text = car.CarName;
                txtCarModelYear.Text = car.CarModelYear.ToString();
                txtColor.Text = car.Color;
                txtCapacity.Text = car.Capacity.ToString();
                txtDescription.Text = car.Description;
                txtImportDate.Text = car.ImportDate.ToString();
                txtRentPrice.Text = car.RentPrice.ToString();
                txtStatus.Text = car.Status.ToString();
                txtProducerID.Text = car.ProducerId;

            }
            catch (Exception ex)
            {

                throw;

            }
        }

        public CarManagementPopUp(string carId, CarManagement carManagement)
        {
            _isAddOrUpdate = false;
            _carId = carId;
            _carManagement = carManagement;
            InitializeComponent();
            SetUpdateForm();
            
        }

        private void SetUpdateForm()
        {
            try
            {
                var car = carRepository.GetCarByID(_carId);
                txtCarId.Text = car.CarId;
                txtCarName.Text = car.CarName;
                txtCarModelYear.Text = car.CarModelYear.ToString();
                txtColor.Text = car.Color;
                txtCapacity.Text = car.Capacity.ToString();
                txtDescription.Text = car.Description;
                txtImportDate.Text = car.ImportDate.ToString();
                txtRentPrice.Text = car.RentPrice.ToString();
                txtStatus.Text = car.Status.ToString();
                txtProducerID.Text = car.ProducerId;
                lbAdd_Update.Content = "Update";
                btnAdd_Update.Content = "Update";
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnAdd_Update_Click(object sender, RoutedEventArgs e)
        {
            if (_isAddOrUpdate)
            {
                carRepository.InsertCar(GetFormInfo());
                _carManagement.LoadCarList();
                MessageBox.Show("Success");
                this.Close();
            }
            else
            {
                carRepository.UpdateCar(GetFormInfo());
                _carManagement.LoadCarList();
                MessageBox.Show("Success");
                this.Close();
            }
        }

        private Car GetFormInfo()
        {
            return new Car
            {
                CarId = txtCarId.Text,
                CarName = txtCarName.Text,
                CarModelYear = int.Parse(txtCarModelYear.Text),
                Color = txtColor.Text,
                Capacity = int.Parse(txtCapacity.Text),
                Description = txtDescription.Text,
                ImportDate = DateTime.Parse(txtImportDate.Text),
                RentPrice = decimal.Parse(txtRentPrice.Text),
                Status = int.Parse(txtStatus.Text),
                ProducerId = txtProducerID.Text
            };
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
