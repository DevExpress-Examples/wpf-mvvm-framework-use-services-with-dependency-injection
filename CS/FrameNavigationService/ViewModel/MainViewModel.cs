using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace FrameNavigation.ViewModel {
    public class MainViewModel : ViewModelBase {
        INavigationService navigationService;

        public MainViewModel(INavigationService navigationService) => this.navigationService = navigationService;

        [Command]
        public void OnLoaded() => navigationService.Navigate("HomeView", null, this);
    }
}
