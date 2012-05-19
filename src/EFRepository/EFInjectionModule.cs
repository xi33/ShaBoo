using Ninject.Modules;
using ShaBoo.Domain.Repositories;

namespace ShaBoo.EFRepositories
{
    public class EFInjectionModule : NinjectModule
    {
        public override void Load()
        {
            // CODE:
            Bind<IDALContext>().To<DALContext>();
        }
    }
}