using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarDetails(decimal min, decimal max);
        List<Car> GetCarDetailsByColorId(int id);
        List<Car> GetCarDetailsByBrandId(int id);
    }
}
