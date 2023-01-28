using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarRepository : ICarRepository
    {
        
        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetList();
        public Car GetCarByID(string carId) => CarDAO.Instance.GetCarByID(carId);
        public void InsertCar(Car car) => CarDAO.Instance.InsertCar(car);
        public void UpdateCar(Car car) => CarDAO.Instance.UpdateCar(car);
        public void DeleteCar(string carID) => CarDAO.Instance.DeleteCustomer(carID);
        public List<Car> GetCarsByCarProducerId(string producerId) => CarDAO.Instance.GetCarsByProducerId(producerId);
        
    }
}
