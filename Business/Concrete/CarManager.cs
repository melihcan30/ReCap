using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarDetails(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarDetailsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarDetailsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
