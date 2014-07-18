using Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ForumService
    {
        [Inject]
        private readonly IRepository _repository;

        public ForumService(IRepository repository)
        {
            _repository = repository;
        }
    }
}
