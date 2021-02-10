using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, ModelYear = "1999",  DailyPrice = 200, Description = "En az iki gün kiralanır."},
                new Car {CarId = 2, BrandId = 1, ColorId = 1, ModelYear = "2010", DailyPrice = 250, Description = "En az üç gün kiralanır."},
                new Car {CarId = 3, BrandId = 1, ColorId = 2, ModelYear = "2019", DailyPrice = 350, Description = "En az bir haftalık kiralanır."},
                new Car {CarId = 4, BrandId = 2, ColorId = 2, ModelYear = "1999", DailyPrice = 225, Description = "En az iki gün kiralanır."},
                new Car {CarId = 5, BrandId = 2, ColorId = 1, ModelYear = "2016", DailyPrice = 330, Description = "En az üç gün kiralanır."},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            // LINQ kullanıyoruz.

            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> Update()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
