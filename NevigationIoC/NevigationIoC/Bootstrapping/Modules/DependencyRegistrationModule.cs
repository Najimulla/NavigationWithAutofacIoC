using Autofac;
using NevigationIoC.Interfaces;
using NevigationIoC.Services;
using Xamarin.Forms;

namespace NevigationIoC.Bootstrapping.Modules
{
    public class DependencyRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();
            builder.RegisterType<Navigator>().As<INavigator>().SingleInstance();
            builder.Register<INavigation>(context => Application.Current.MainPage.Navigation).SingleInstance();
        }
    }
}
