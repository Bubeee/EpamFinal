using DAL.ORM;
using Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ForumNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository>().To<ORMRepository>();
        } 
    }
}
