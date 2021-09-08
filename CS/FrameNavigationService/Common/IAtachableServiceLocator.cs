using DevExpress.Mvvm.UI;
using System;

namespace FrameNavigation.Common {
    public interface IAtachableServiceLocator {
        ServiceBase GetServiceBase(Type serviceType);
    }
}
