using GarciaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GarciaShop.Data.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int Id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicated);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
