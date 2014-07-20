using Interfaces;
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
    public class MessageService
    {
        [Inject]
        private readonly IMessageRepository _repository;

        public MessageService(IMessageRepository repository)
        {
            _repository = repository;
        }

        public void Add(Message item)
        {
            _repository.Add(item);
        }

        public void Delete(Message item)
        {
            _repository.Delete(item);
        }

        public IQueryable<Message> GetAll()
        {
            return _repository.GetAll();
        }

        public void Edit(Message item)
        {
            _repository.Edit(item);
        }

        public Message GetById(int key)
        {
            return _repository.GetById(key);
        }
    }
}
