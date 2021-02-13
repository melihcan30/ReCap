using Entities.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetCarDetails(Expression<Func<T, bool>> filter = null);
        List<T> GetCarDetailsByColorId(Expression<Func<T, bool>> filter = null);
        List<T> GetCarDetailsByBrandId(Expression<Func<T, bool>> filter = null);
    }
}