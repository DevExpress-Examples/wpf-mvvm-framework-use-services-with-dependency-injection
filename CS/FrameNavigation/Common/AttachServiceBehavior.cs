using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using System.Windows;

namespace FrameNavigation.Common {
    public class AttachServiceBehavior : Behavior<DependencyObject> {
        public static readonly DependencyProperty AttachableServiceProperty =
            DependencyProperty.Register(nameof(AttachableService), typeof(ServiceBase), typeof(AttachServiceBehavior), new PropertyMetadata(null, OnAttachableServiceChanged));

        static void OnAttachableServiceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            (e.OldValue as ServiceBase)?.Detach();
            ((AttachServiceBehavior)d).AttachService();
        }

        public ServiceBase AttachableService {
            get => (ServiceBase)GetValue(AttachableServiceProperty);
            set => SetValue(AttachableServiceProperty, value);
        }

        protected override void OnAttached() {
            base.OnAttached();
            AttachService();
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AttachableService?.Detach();
        }

        void AttachService() {
            if(AttachableService == null || AssociatedObject == null)
                return;
            if(AttachableService.IsAttached)
                AttachableService.Detach();
            AttachableService.Attach(AssociatedObject);
        }
    }
}
