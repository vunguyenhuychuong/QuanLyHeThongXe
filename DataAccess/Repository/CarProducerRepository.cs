using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarProducerRepository : ICarProducerRepository
    {
        public CarProducer GetCarByproducerID(string producerID) => CarProducerDAO.Instance.GetCarByProducerId(producerID);
        
    }
}
