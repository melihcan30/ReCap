using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetAll(object p);
        List<Car> GetAll(Func<object, bool> p);
        List<Car> GetAll();
    }
}
