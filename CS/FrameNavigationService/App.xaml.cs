using Autofac;
using DevExpress.Mvvm;
using DevExpress.Xpf.WindowsUI.Navigation;
using FrameNavigation.Common;
using FrameNavigation.ViewModel;
using System;
using System.Windows;

namespace FrameNavigation {
    public interface IInjectionResolver {
        object Resolve(Type type, object key, string name);
    }

    public partial class App : Application, IInjectionResolver {
        IContainer Container { get; set; }
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            Container = BuildUpContainer();
            DISource.Resolver = this;
        }
        object IInjectionResolver.Resolve(Type type, object key, string name) {
            if(type == null)
                return null;
            if(key != null)
                return Container.ResolveKeyed(key, type);
            if(name != null)
                return Container.ResolveNamed(name, type);
            return Container.Resolve(type);
        }

        static IContainer BuildUpContainer() {
            var builder = new ContainerBuilder();
            builder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<HomeViewModel>().AsSelf();
            builder.RegisterType<DetailViewModel>().AsSelf();
            return builder.Build();
        }
    }
}
