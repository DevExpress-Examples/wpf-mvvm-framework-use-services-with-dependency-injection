using DevExpress.Mvvm.UI;
using System;

namespace FrameNavigation.Common {
    public interface IAtachableServicLocator {
        ServiceBase GetServiceBase(Type serviceType);
    }
}
