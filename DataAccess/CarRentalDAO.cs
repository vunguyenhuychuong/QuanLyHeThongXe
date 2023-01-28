using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarRentalDAO
    {
        CarRentalSystemDBContext dBContext = new CarRentalSystemDBContext();
        ICarRepository carRepository = new CarRepository();
        ICustomerRepository customerRepository = new CustomerRepository();

        private static CarRentalDAO instance = null;
        private static readonly object instanceLock = new object();
        private CarRentalDAO() { }

        public static CarRentalDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarRentalDAO();
                    }
                    return instance;
                }
            }
        }

        public CarRental GetCarRental(string customerId, string carId)
        {
            var carRentalList = (from a in dBContext.CarRentals where a.CustomerId == customerId && a.CarId == carId select a).SingleOrDefault();
            return carRentalList;
        }

        public void DeleteCarRental(string customerId, string carId)
        {
            if (GetCarRental(customerId,carId) != null)
            {
                dBContext.CarRentals.Remove(GetCarRental(customerId, carId));
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Invalid Id");
            }
        }

        public List<CarRental> GetCarRental(string customerId)
        {
            var carRentalsList = new List<CarRental>();
            try
            {
                carRentalsList = (from a in dBContext.CarRentals where a.CustomerId == customerId select a).ToList();
                if (carRentalsList == null) carRentalsList = new List<CarRental>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return carRentalsList;
        }

        public void InsertCarRental(CarRental carRental)
        {
            if(GetCarRental(carRental.CarId , carRental.CustomerId) == null)
            {
                dBContext.CarRentals.Add(carRental);
                dBContext.SaveChanges();
            }
        }

        public void UpdateCarRental(CarRental carRental)
        {
            CarRental carRental1 = GetCarRental(carRental.CarId, carRental.CustomerId);
            try
            {
                if (carRental1 != null)
                {
                    carRental1.CustomerId = carRental.CustomerId;
                    carRental1.CarId = carRental.CarId;
                    carRental1.PickupDate = carRental.PickupDate;
                    carRental1.ReturnDate = carRental.ReturnDate;
                    carRental1.RentPrice = carRental.RentPrice;
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CarRental> Filter(DateTime a, DateTime b)
        {
            var carRent = new List<CarRental>();
            var fil = new List<CarRental>();
            try
            {
                using var context = new CarRentalSystemDBContext();
                carRent = context.CarRentals.ToList();
                for (int i = 0; i < carRent.Count(); i++)
                {
                    if ((carRent[i].PickupDate >= a && carRent[i].ReturnDate <= b))
                    {
                        fil.Add(carRent[i]);
                    }
                }
                fil = fil.OrderByDescending(x => x.PickupDate).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return fil;
        }
    }
}
