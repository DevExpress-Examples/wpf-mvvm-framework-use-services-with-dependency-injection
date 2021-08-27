using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.WindowsUI.Navigation;
using FrameNavigation.ViewModel;
using System;

namespace FrameNavigation.Common {
    public class ServiceLocator : IAtachableServicLocator {
        readonly IContainer container;

        public MainViewModel MainViewModel => container.Resolve<MainViewModel>();
        public HomeViewModel HomeViewModel => container.Resolve<HomeViewModel>();
        public DetailViewModel DetailViewModel => container.Resolve<DetailViewModel>();

        public ServiceLocator() => container = BuildUpContainer();

        static IContainer BuildUpContainer() {
            var builder = new ContainerBuilder();

            builder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<HomeViewModel>().AsSelf();
            builder.RegisterType<DetailViewModel>().AsSelf();

            return builder.Build();
        }

        public ServiceBase GetServiceBase(Type serviceType) => container.Resolve(serviceType) as ServiceBase;
    }
}
