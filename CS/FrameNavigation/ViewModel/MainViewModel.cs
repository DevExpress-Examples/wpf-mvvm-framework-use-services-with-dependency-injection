using DevExpress.Mvvm;
using System.Windows.Input;

namespace FrameNavigation.ViewModel {
    public class MainViewModel {
        public INavigationService NavigationService { get; }

        public ICommand OnLoadedCommand { get; }

        public MainViewModel(INavigationService navigationService) {
            NavigationService = navigationService;
            OnLoadedCommand = new DelegateCommand(OnLoaded);
        }

        public void OnLoaded() => NavigationService.Navigate("HomeView", null, this);
    }
}
