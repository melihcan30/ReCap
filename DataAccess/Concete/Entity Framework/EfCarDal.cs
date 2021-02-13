using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concete.Entity_Framework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDataContext>, ICarDal
    {
        public List<Car> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetCarDetailsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetCarDetailsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }
    }
}
