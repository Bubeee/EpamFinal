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
    public class TopicORMRepository : ITopicRepository, IDisposable
    {
        private DbContext db = new ForumDbContext();

        public void Dispose()
        {
            this.db.Dispose();
        }

        public void Add(Topic item)
        {
            db.Set<ForumDb.DbEntities.Topic>().Add(EntityConverter.Convert(item));
            db.SaveChanges();
        }

        public void Edit(Topic item)
        {
            db.Set<ForumDb.DbEntities.Topic>().Attach(EntityConverter.Convert(item));
            db.Entry<ForumDb.DbEntities.Topic>(EntityConverter.Convert(item)).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Topic item)
        {
            var temp = db.Set<ForumDb.DbEntities.Topic>().First(n => n.Id == item.Id);
            if (temp != null)
            {
                db.Set<ForumDb.DbEntities.Topic>().Remove(EntityConverter.Convert(item));
                db.SaveChanges();
            }
        }

        public Topic GetById(int key)
        {
            return EntityConverter.Convert(db.Set<ForumDb.DbEntities.Topic>().Find(key));
        }

        public IQueryable<Topic> GetAll()
        {
            var temp = new List<Topic>();
            foreach (var item in db.Set<ForumDb.DbEntities.Topic>())
            {
                temp.Add(EntityConverter.Convert(item));
            }
            return temp.AsQueryable<Topic>();
        }
    }
}
