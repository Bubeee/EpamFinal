using ForumDb;
using Interfaces;
using Interfaces.Repositories;
using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM
{
    public class CategoryORMRepository : ICategoryRepository, IDisposable
    {
        private DbContext db = new ForumDbContext();

        public void Dispose()
        {
            this.db.Dispose();
        }

        public void Add(Category item)
        {
            db.Set<ForumDb.DbEntities.Category>().Add(EntityConverter.Convert(item));
            db.SaveChanges();
        }

        public void Edit(Category item)
        {
            db.Set<ForumDb.DbEntities.Category>().Attach(EntityConverter.Convert(item));
            db.Entry<ForumDb.DbEntities.Category>(EntityConverter.Convert(item)).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Category item)
        {
            var temp = db.Set<ForumDb.DbEntities.Category>().First(n => n.Id == item.Id);
            if (temp != null)
            {
                db.Set<ForumDb.DbEntities.Category>().Remove(EntityConverter.Convert(item));
                db.SaveChanges();
            }
        }

        public Category GetById(int key)
        {
            return EntityConverter.Convert(db.Set<ForumDb.DbEntities.Category>().Find(key));
        }

        public IQueryable<Category> GetAll()
        {
            var temp = new List<Category>();
            foreach (var item in db.Set<ForumDb.DbEntities.Category>())
            {
                temp.Add(EntityConverter.Convert(item));
            }
            return temp.AsQueryable<Category>();
        }
    }
}
