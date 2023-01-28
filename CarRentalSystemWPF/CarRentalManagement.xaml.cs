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
    /// Interaction logic for CarRentalManagement.xaml
    /// </summary>
    public partial class CarRentalManagement : Window
    {   
        ICarRentalRepository _carRentalRepository = new CarRentalRepository();
        private string _carId;
        private string _customerId;

        public CarRentalManagement(string customerId)
        {   
            _customerId = customerId;
            InitializeComponent();
            LoadCarRentalList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CarRentalManagementPopUp carRentalManagementPopUp = new CarRentalManagementPopUp(_customerId, this);
            carRentalManagementPopUp.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBoxResult dialogResult = MessageBox.Show("This action can't be reversed", "Are you sure?", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    _carRentalRepository.DeleteCarRental(txtCarId.Text,txtCustomerId.Text);
                    LoadCarRentalList();
                }
            }
            else
            {
                MessageBox.Show("Please select an order detail");
            }
        }

        public void LoadCarRentalList()
        {
            lsvCarRental.ItemsSource = _carRentalRepository.GetCarRentals(_customerId).ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCarId.Text))
            {
                CarRentalManagementPopUp carRentalPopup = new CarRentalManagementPopUp(_carId, _customerId, this);
                carRentalPopup.Show();
            }
            else
            {
                MessageBox.Show("Please select an order detail");
            }
        }

        private void btnCarRental_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
