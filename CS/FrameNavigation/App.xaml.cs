using Autofac;
using Autofac.Features.ResolveAnything;
using DevExpress.Mvvm;
using DevExpress.Xpf.WindowsUI.Navigation;
using FrameNavigation.Common;
using System;
using System.Windows;

namespace FrameNavigation {
    public partial class App : Application {
        IContainer Container { get; set; }
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            Container = BuildUpContainer();
            DISource.Resolver = Resolve;
        }
        object Resolve(Type type, object key, string name) {
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
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            builder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();
            return builder.Build();
        }
    }
}
