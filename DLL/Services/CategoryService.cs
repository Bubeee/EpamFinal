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
    public class CategoryService
    {
        [Inject]
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public void Add(Category item)
        {
            _repository.Add(item);
        }

        public void Delete(Category item)
        {
            _repository.Delete(item);
        }

        public IQueryable<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public void Edit(Category item)
        {
            _repository.Edit(item);
        }

        public Category GetById(int key)
        {
            return _repository.GetById(key);
        }
    }
}
