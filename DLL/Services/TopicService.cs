using Interfaces.Entities;
using Interfaces.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TopicService
    {
        [Inject]
        private readonly ITopicRepository _repository;

        public TopicService(ITopicRepository repository)
        {
            _repository = repository;
        }

        public void Add(Topic item)
        {
            _repository.Add(item);
        }

        public void Delete(Topic item)
        {
            _repository.Delete(item);
        }

        public IQueryable<Topic> GetAll()
        {
            return _repository.GetAll();
        }

        public void Edit(Topic item)
        {
            _repository.Edit(item);
        }

        public Topic GetById(int key)
        {
            return _repository.GetById(key);
        }
    }
}
