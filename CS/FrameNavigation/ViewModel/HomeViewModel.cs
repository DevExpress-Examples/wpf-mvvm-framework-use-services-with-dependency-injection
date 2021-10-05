using DevExpress.Mvvm;
using System.Windows.Input;

namespace FrameNavigation.ViewModel {
    public class HomeViewModel {
        INavigationService navigationService;

        public ICommand NavigateDetailsCommand { get; }
        public ICommand NavigateForwardCommand { get; }

        public HomeViewModel(INavigationService navigationService) {
            this.navigationService = navigationService;
            NavigateDetailsCommand = new DelegateCommand(NavigateDetails);
            NavigateForwardCommand = new DelegateCommand(NavigateForward, CanNavigateForward);
        }

        public void NavigateDetails() => navigationService.Navigate("DetailView", null, this);
        public void NavigateForward() => navigationService.GoForward();
        public bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}
