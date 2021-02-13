using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetCarDetails(decimal min, decimal max);
        List<Color> GetCarDetailsByColorId(int id);
        List<Color> GetCarDetailsByBrandId(int id);
    }
}
