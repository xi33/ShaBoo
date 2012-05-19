using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Ninject;
using ShaBoo.EFRepositories;
using ShaBoo.Services;

namespace ShaBoo.Web.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel nKernel;
        public NinjectDependencyResolver()
        {
            nKernel = new StandardKernel();
            nKernel.Load(new EFInjectionModule());
            nKernel.Load(new CoreInjectionModule());

            //AddBindings();
        }

        //private void AddBindings()
        //{
        //    // CODE:
        //    nKernel.Bind<IDALContext>().To<DALContext>();
        //}

        public object GetService(Type serviceType)
        {
            return nKernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return nKernel.GetAll(serviceType);
        }
    }
}