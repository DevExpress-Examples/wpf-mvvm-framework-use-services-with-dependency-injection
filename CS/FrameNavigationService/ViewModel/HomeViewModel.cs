using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace FrameNavigation.ViewModel {
    public class HomeViewModel : ViewModelBase {
        INavigationService navigationService;

        public HomeViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [Command]
        public void NavigateDetails() => navigationService.Navigate("DetailView", null, this);
        [Command]
        public void NavigateForward() => navigationService.GoForward();
        public bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}
