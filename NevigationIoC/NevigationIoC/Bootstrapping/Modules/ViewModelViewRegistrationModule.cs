using Autofac;
using NevigationIoC.ViewModels;
using NevigationIoC.Views;

namespace NevigationIoC.Bootstrapping.Modules
{
    public class ViewModelViewRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HomePage>().SingleInstance();
            builder.RegisterType<HomeBaseViewModel>().SingleInstance();

            builder.RegisterType<SecondPage>();
            builder.RegisterType<SecondViewModel>();
        }
    }
}
