using ForumDB;
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
        public static Category ToEntity(ForumCategory dalEntity)
        {
            return new Category() { 
                Id = dalEntity.Id, 
                Name = dalEntity.Name 
            };
        }
        public static Message ToEntity(ForumMessage dalEntity)
        {
            return new Message() { 
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
        public static Topic ToEntity(ForumTopic dalEntity)
        {
            return new Topic() {
                Id = dalEntity.Id,
                InsertDate = dalEntity.InsertDate,
                UpdateDate = dalEntity.UpdateDate,
                Title = dalEntity.Title,
                UserId = dalEntity.UserId,
                Description = dalEntity.Description,
                ForumCategoryId = dalEntity.ForumCategoryId
            };
        }

        public static ForumCategory ToEntity(Category entity)
        {
            return new ForumCategory()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
        public static ForumMessage ToEntity(Message entity)
        {
            return new ForumMessage()
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
        public static ForumTopic ToEntity(Topic entity)
        {
            return new ForumTopic()
            {
                Id = entity.Id,
                InsertDate = entity.InsertDate,
                UpdateDate = entity.UpdateDate,
                Title = entity.Title,
                UserId = entity.UserId,
                Description = entity.Description,
                ForumCategoryId = entity.ForumCategoryId
            };
        }

    }
}
