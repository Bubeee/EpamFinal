using ForumDB;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM
{
    public class ORMRepository : IRepository
    {
        private Entities db = new Entities();
        public void Add<T>(T item) where T : class, IEntity
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void Delete<T>(T item) where T : class, IEntity
        {
            var temp = db.Set<T>().First(n => n.Id == item.Id);
            if (temp != null)
            {
                db.Set<T>().Remove(item);
                db.SaveChanges();
            }
        }

        public IQueryable<T> SearchFor<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate) where T : class, IEntity
        {
            return db.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll<T>() where T : class, IEntity
        {
            return db.Set<T>();
        }

        public void Edit<T>(T item) where T : class, IEntity
        {
            db.Set<T>().Attach(item);
            db.Entry<T>(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public T GetById<T>(int key) where T : class, IEntity
        {
            return db.Set<T>().Find(key);
        }
    }
}
