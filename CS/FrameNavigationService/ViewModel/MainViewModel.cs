using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace FrameNavigation.ViewModel {
    public class MainViewModel : ViewModelBase {
        public INavigationService NavigationService { get; }

        public MainViewModel(INavigationService navigationService) => NavigationService = navigationService;

        [Command]
        public void OnLoaded() => NavigationService.Navigate("HomeView", null, this);
    }
}
