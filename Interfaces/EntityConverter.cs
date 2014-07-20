using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public static class EntityConverter
    {
        public static Category Convert(ForumDb.DbEntities.Category dalEntity)
        {
            return new Category()
            {
                Id = dalEntity.Id,
                Name = dalEntity.Name
            };
        }
        public static Message Convert(ForumDb.DbEntities.Message dalEntity)
        {
            return new Message()
            {
                Id = dalEntity.Id,
                IdParentMessage = dalEntity.IdParentMessage,
                InsertDate = dalEntity.InsertDate,
                UpdateDate = dalEntity.UpdateDate,
                Tag = dalEntity.Tag,
                Title = dalEntity.Title,
                Body = dalEntity.Body,
                UserId = dalEntity.UserId,
                TopicId = dalEntity.TopicId
            };
        }
        public static Topic Convert(ForumDb.DbEntities.Topic dalEntity)
        {
            return new Topic()
            {
                Id = dalEntity.Id,
                InsertDate = dalEntity.InsertDate,
                UpdateDate = dalEntity.UpdateDate,
                Title = dalEntity.Title,
                UserId = dalEntity.UserId,
                Description = dalEntity.Description,
                CategoryId = dalEntity.Category.Id
            };
        }

        public static ForumDb.DbEntities.Category Convert(Category entity)
        {
            return new ForumDb.DbEntities.Category()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
        public static ForumDb.DbEntities.Message Convert(Message entity)
        {
            return new ForumDb.DbEntities.Message()
            {
                Id = entity.Id,
                IdParentMessage = entity.IdParentMessage,
                InsertDate = entity.InsertDate,
                UpdateDate = entity.UpdateDate,
                Tag = entity.Tag,
                Title = entity.Title,
                Body = entity.Body,
                UserId = entity.UserId,
                TopicId = entity.TopicId
            };
        }
        public static ForumDb.DbEntities.Topic Convert(Topic entity)
        {
            return new ForumDb.DbEntities.Topic()
            {
                Id = entity.Id,
                InsertDate = entity.InsertDate,
                UpdateDate = entity.UpdateDate,
                Title = entity.Title,
                UserId = entity.UserId,
                Description = entity.Description                
            };
        }
    }
}
