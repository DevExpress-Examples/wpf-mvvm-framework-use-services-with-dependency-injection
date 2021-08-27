using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace FrameNavigation.ViewModel {
    public class DetailViewModel : ViewModelBase {
        INavigationService navigationService;

        public DetailViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [Command]
        public void NavigateNextDetail() => navigationService.Navigate("NextDetailView", null, this);
        [Command]
        public void NavigateForward() => navigationService.GoForward();
        public bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}