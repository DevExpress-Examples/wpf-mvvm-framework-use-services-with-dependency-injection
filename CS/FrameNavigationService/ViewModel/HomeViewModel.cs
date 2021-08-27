using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;

namespace FrameNavigation.ViewModel {
    [GenerateViewModel(ImplementISupportParentViewModel = true)]
    public partial class HomeViewModel {
        INavigationService navigationService;

        public HomeViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [GenerateCommand]
        void NavigateDetails() => navigationService.Navigate("DetailView", null, this);
        [GenerateCommand]
        void NavigateForward() => navigationService.GoForward();
        bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}
