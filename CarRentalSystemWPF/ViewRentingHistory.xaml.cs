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
    /// Interaction logic for ViewRentingHistory.xaml
    /// </summary>
    public partial class ViewRentingHistory : Window
    {
        private string _customerId;
        ICustomerRepository customerRepository = new CustomerRepository();

        public ViewRentingHistory(string customerId)
        {   
            _customerId = customerId;
            InitializeComponent();
            LoadCarRentalList();
        }

        public void LoadCustomerObject()
        {
            txtSelectedId.Text = _customerId;
        }

        public void LoadCarRentalList()
        {
            lsvViewRentingHistory.ItemsSource = customerRepository.ViewRentingHistory(_customerId).ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lsvView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
