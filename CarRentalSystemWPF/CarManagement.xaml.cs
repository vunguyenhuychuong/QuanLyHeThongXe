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
    /// Interaction logic for CarManagement.xaml
    /// </summary>
    public partial class CarManagement : Window
    {
        private ICarRepository carRepository = new CarRepository();
        private ICarProducerRepository carProducerRepository = new CarProducerRepository();
        public CarManagement()
        {
            InitializeComponent();
            LoadCarList();
        }

        public CarManagement(string carId)
        {
            InitializeComponent();
            LoadCarList();
        }

        public void LoadCarList()
        {
            lsvCar.ItemsSource = carRepository.GetCars();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CarManagementPopUp carManagementPopup = new CarManagementPopUp(this);
            carManagementPopup.Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                CarManagementPopUp carManagementPopUp = new CarManagementPopUp(txtSelectedId.Text, this);
                carManagementPopUp.Show();
            }
            else
            {
                MessageBox.Show("Please select a member");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtSelectedId.Text))
            {
                MessageBox.Show("Please select a car you want to delete");
            }
            else
            {
                MessageBoxResult dialogResult = MessageBox.Show("This may cause delete carProducer ,Are you want to countinue?", "This action can'be reverse", MessageBoxButton.YesNo);
                if(dialogResult == MessageBoxResult.Yes) 
                {
                    carRepository.DeleteCar(txtSelectedId.Text);
                    LoadCarList();
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lsvCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCarRental_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
