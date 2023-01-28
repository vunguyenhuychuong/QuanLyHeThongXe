using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarProducerDAO
    {
        CarRentalSystemDBContext dBContext = new CarRentalSystemDBContext();
        List<CarProducer> carProducerList = new List<CarProducer>();

        private static CarProducerDAO instance = null;
        private static readonly object instanceLock = new object();

        private CarProducerDAO() { }
        public static CarProducerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarProducerDAO();
                    }
                    return instance;
                }
            }
        }


        public CarProducer GetCarByProducerId(string producerID)
        {
            CarProducer carProducer = dBContext.CarProducers.Include(p => p.Cars).SingleOrDefault(p => p.ProducerId == producerID);
            return carProducer;
        }
    }
}
