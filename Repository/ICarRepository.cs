using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(String carId);
        void InsertCar(Car car);
        void DeleteCar(string carID);
        void UpdateCar(Car car);
        List<Car> GetCarsByCarProducerId(string producerId);
    }
}
