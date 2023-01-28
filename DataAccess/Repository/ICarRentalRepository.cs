using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarRentalRepository
    {
        List<CarRental> GetCarRentals(string customerId);
        CarRental GetCarRental(string customerId, string carId);
        void UpdateCarRental(CarRental orderDetail);
        void DeleteCarRental(string customerId, string carId);
        void InsertCarRental(CarRental orderDetail);
        List<CarRental> GetCarRentByDate(DateTime dateTime1, DateTime dateTime2);
    }
}
