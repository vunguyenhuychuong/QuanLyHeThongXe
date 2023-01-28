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

        public List<CarRental> GetCarRentals(string cutomerId) => CarRentalDAO.Instance.GetCarRental(cutomerId);

        public CarRental GetCarRental(string customerId, string carId) => CarRentalDAO.Instance.GetCarRental(customerId, carId);

        public void InsertCarRental(CarRental carRental) => CarRentalDAO.Instance.InsertCarRental(carRental);

        public void UpdateCarRental(CarRental carRental) => CarRentalDAO.Instance.UpdateCarRental(carRental);

        public List<CarRental> GetCarRentByDate(DateTime dateTime1, DateTime dateTime2) => CarRentalDAO.Instance.Filter(dateTime1, dateTime2);

    }
}
