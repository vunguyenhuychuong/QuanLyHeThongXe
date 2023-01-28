using BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarDAO
    {
        CarRentalSystemDBContext dBContext = new CarRentalSystemDBContext();
        List<Car> car = new List<Car>();

        private static CarDAO instance = null;
        private static readonly object instanceLock = new object();

        private CarDAO() { }

        public static CarDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDAO();
                    }
                    return instance;
                }
            }
        }

        public Car GetCarById(String carID)
        {
            Car car = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                car = context.Cars.SingleOrDefault(c => c.CarId == carID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return car;
        }

        public IEnumerable<Car> GetList()
        {
            List<Car> car;
            try
            {
                var db = new CarRentalSystemDBContext();
                car = db.Cars.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return car;
        }



        public Car GetCarByID(string carId)
        {
            Car car = dBContext.Cars.SingleOrDefault(p => p.CarId == carId);
            return car;
        }

        public void DeleteCustomer(string carID)
        {
            if (GetCarByID(carID) != null)
            {
                dBContext.Remove(dBContext.Cars.First<Car>(p => p.CarId == carID));
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Invalid ID");
            }
        }

        public void InsertCar(Car car)
        {
            if (GetCarByID(car.CarId) == null )
            {                  
                dBContext.Cars.Add(car);
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Car ID is already exists.");

            }
        }

        public void UpdateCar(Car car)
        {
            var carinfo = (from u in dBContext.Cars where u.CarId == car.CarId select u).SingleOrDefault();
            if (carinfo != null)
            {
                carinfo.CarId = car.CarId;
                carinfo.CarName = car.CarName;
                carinfo.CarModelYear = car.CarModelYear;
                carinfo.Color = car.Color;
                carinfo.Capacity = car.Capacity;
                carinfo.Description = car.Description;
                carinfo.ImportDate = car.ImportDate;
                carinfo.RentPrice = car.RentPrice;
                carinfo.Status = car.Status;
                carinfo.ProducerId = car.ProducerId;
                dBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Staff does not exitst");
            }
        }

        public List<Car> GetCarsByProducerId(string producerId)
        {
           List<Car>? cars = (from a in dBContext.Cars.ToList() where a.ProducerId == producerId select a).ToList();
            return cars;
        }

      
    }
}

