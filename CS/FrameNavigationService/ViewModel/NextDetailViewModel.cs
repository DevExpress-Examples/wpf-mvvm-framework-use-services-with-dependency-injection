using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;

namespace FrameNavigation.ViewModel {
    [GenerateViewModel(ImplementISupportParentViewModel = true)]
    public partial class NextDetailViewModel {
        INavigationService navigationService;

        public NextDetailViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [GenerateCommand]
        void NavigateHome() => navigationService.Navigate("HomeView");
        [GenerateCommand]
        void NavigateForward() => navigationService.GoForward();
        bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}
