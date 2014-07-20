using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Add(T item);
        void Edit(T item);
        void Delete(T item);
        T GetById(int key);
        IQueryable<T> GetAll();
       // IEnumerable<T> SearchFor(Expression<Func<T, bool>> predicate);
    }
}
