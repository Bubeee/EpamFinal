using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepository
    {
        void Add<T>(T item) where T : class, IEntity;
        void Delete<T>(T item) where T : class, IEntity;
        IQueryable<T> SearchFor<T>(Expression<Func<T, bool>> predicate) where T : class, IEntity;
        IQueryable<T> GetAll<T>() where T : class, IEntity;
        T GetById<T>(int key) where T : class, IEntity;
        void Edit<T>(T item) where T : class, IEntity;
    }
}
