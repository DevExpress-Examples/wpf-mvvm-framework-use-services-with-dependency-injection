using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using System;
using System.Windows;

namespace FrameNavigation.Common {
    public class AttachServiceBehavior : Behavior<DependencyObject> {
        ServiceBase service;

        public static readonly DependencyProperty ServiceLocatorProperty =
            DependencyProperty.Register(nameof(ServiceLocator), typeof(ServiceLocator), typeof(AttachServiceBehavior), new PropertyMetadata(null, OnServiceChanged));
        public static readonly DependencyProperty ServiceTypeProperty =
            DependencyProperty.Register(nameof(ServiceType), typeof(Type), typeof(AttachServiceBehavior), new PropertyMetadata(null, OnServiceChanged));

        public ServiceLocator ServiceLocator {
            get => (ServiceLocator)GetValue(ServiceLocatorProperty);
            set => SetValue(ServiceLocatorProperty, value);
        }
        public Type ServiceType {
            get => (Type)GetValue(ServiceTypeProperty);
            set => SetValue(ServiceTypeProperty, value);
        }

        static void OnServiceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((AttachServiceBehavior)d).AttachService();

        protected override void OnAttached() {
            base.OnAttached();
            AttachService();
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            service?.Detach();
        }

        void AttachService() {
            if(service != null || ServiceLocator == null || ServiceType == null || AssociatedObject == null)
                return;
            service = ServiceLocator.GetServiceBase(ServiceType);
            service?.Attach(AssociatedObject);
        }
    }
}
