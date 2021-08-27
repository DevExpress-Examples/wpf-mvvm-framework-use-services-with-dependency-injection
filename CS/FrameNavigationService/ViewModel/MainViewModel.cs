using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;

namespace FrameNavigation.ViewModel {
    [GenerateViewModel(ImplementISupportParentViewModel = true)]
    public partial class MainViewModel {
        INavigationService navigationService;

        public MainViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [GenerateCommand]
        void OnLoaded() => navigationService.Navigate("HomeView", null, this);
    }
}
