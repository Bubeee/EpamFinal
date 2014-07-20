using ForumDb;
using Interfaces;
using Interfaces.Repositories;
using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.ORM
{
    public class MessageORMRepository : IMessageRepository, IDisposable
    {
        private DbContext db = new ForumDbContext();
        
        public void Dispose()
        {
            this.db.Dispose();
        }

        public void Add(Message item)
        {
            db.Set<ForumDb.DbEntities.Message>().Add(EntityConverter.Convert(item));
            db.SaveChanges();
        }

        public void Edit(Message item)
        {
            db.Set<ForumDb.DbEntities.Message>().Attach(EntityConverter.Convert(item));
            db.Entry<ForumDb.DbEntities.Message>(EntityConverter.Convert(item)).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Message item)
        {
            var temp = db.Set<ForumDb.DbEntities.Message>().First(n => n.Id == item.Id);
            if (temp != null)
            {
                db.Set<ForumDb.DbEntities.Message>().Remove(EntityConverter.Convert(item));
                db.SaveChanges();
            }
        }

        public Message GetById(int key)
        {
            return EntityConverter.Convert(db.Set<ForumDb.DbEntities.Message>().Find(key));
        }

        public IQueryable<Message> GetAll()
        {
            var temp = new List<Message>();
            foreach (var item in db.Set<ForumDb.DbEntities.Message>())
            {
                temp.Add(EntityConverter.Convert(item));
            }
            return temp.AsQueryable<Message>();
        }
    }
}
