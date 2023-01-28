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
        IEnumerable<CarRental> GetCarRentals(int OrderId);
        CarRental GetCarRental(string customerId, string carId);
        void UpdateCarRental(CarRental orderDetail);
        void DeleteCarRental(string customerId, string carId);
        void InsertCarRental(CarRental orderDetail);
    }
}
