using Ninject.Modules;
using ShaBoo.Domain.Services;

namespace ShaBoo.Services
{
    public class CoreInjectionModule : NinjectModule
    {
        public override void Load()
        {
            // CODE:
            Bind<IBLLService>().To<BLLService>();
        }
    }
}