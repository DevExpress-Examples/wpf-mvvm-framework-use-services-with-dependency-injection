using DevExpress.Mvvm;
using System.Windows.Input;

namespace FrameNavigation.ViewModel {
    public class DetailViewModel {
        INavigationService navigationService;

        public ICommand NavigateNextDetailCommand { get; }
        public ICommand NavigateForwardCommand { get; }

        public DetailViewModel(INavigationService navigationService) {
            this.navigationService = navigationService;
            NavigateNextDetailCommand = new DelegateCommand(NavigateNextDetail);
            NavigateForwardCommand = new DelegateCommand(NavigateForward, CanNavigateForward);
        }

        public void NavigateNextDetail() => navigationService.Navigate("NextDetailView", null, this);
        public void NavigateForward() => navigationService.GoForward();
        public bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}