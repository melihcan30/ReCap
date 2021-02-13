using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetCarDetails(decimal min, decimal max);
        List<Brand> GetCarDetailsByColorId(int id);
        List<Brand> GetCarDetailsByBrandId(int id);
    }
}
