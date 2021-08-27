using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;

namespace FrameNavigation.ViewModel {
    [GenerateViewModel(ImplementISupportParentViewModel = true)]
    public partial class DetailViewModel {
        INavigationService navigationService;

        public DetailViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [GenerateCommand]
        void NavigateNextDetail() => navigationService.Navigate("NextDetailView", null, this);
        [GenerateCommand]
        void NavigateForward() => navigationService.GoForward();
        bool CanNavigateForward() => navigationService != null && navigationService.CanGoForward;
    }
}