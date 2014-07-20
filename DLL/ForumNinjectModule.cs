using DAL.ORM;
using Interfaces;
using Interfaces.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ForumNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMessageRepository>().To<MessageORMRepository>();
            this.Bind<ICategoryRepository>().To<CategoryORMRepository>();
            this.Bind<ITopicRepository>().To<TopicORMRepository>();
            this.Bind<CategoryService>().ToSelf();
            this.Bind<TopicService>().ToSelf();
            this.Bind<MessageService>().ToSelf();
        }
    }
}
