using GarciaShop.Data.Interfaces;
using GarciaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GarciaShop.Data
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicated)
        {
            throw new NotImplementedException();
        }
        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

    }
}
