using Ninject.Modules;

namespace UsingNInject
{
    public class ReportModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrinter>().To<LaserPrinter>();
        }
    }
}