using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarRentalRepository : ICarRentalRepository
    {
        public void DeleteCarRental(string customerId, string carId) => CarRentalDAO.Instance.DeleteCarRental(customerId, carId);

        public IEnumerable<CarRental> GetCarRentals(int CarId) => CarRentalDAO.Instance.GetOrderDetails(CarId);

        public CarRental GetCarRental(string customerId, string carId) => CarRentalDAO.Instance.GetOrderDetail(customerId, carId);

        public void InsertCarRental(CarRental carRental) => CarRentalDAO.Instance.InsertCarRental(carRental);

        public void UpdateCarRental(CarRental carRental) => CarRentalDAO.Instance.UpdateCarRental(carRental);
    }
}
