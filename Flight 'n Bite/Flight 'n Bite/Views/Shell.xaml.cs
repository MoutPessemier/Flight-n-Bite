using Template10.Controls;
using Template10.Services.NavigationService;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Flight__n_Bite.ViewModels;
using Flight__n_Bite.Models;

namespace Flight__n_Bite.Views
{
    public sealed partial class Shell : Page
    {
        public static Shell Instance { get; set; }
        public static HamburgerMenu HamburgerMenu => Instance.MyHamburgerMenu;
        Services.SettingsServices.SettingsService _settings;
        public static ShellViewModel viewModel => Instance.MyViewModel;
        public static Passenger Passenger { get; set; }
        public static Personnel Personnel { get; set; }

        public Shell()
        {
            Instance = this;
            InitializeComponent();
            _settings = Services.SettingsServices.SettingsService.Instance;
        }

        public Shell(INavigationService navigationService) : this()
        {
            SetNavigationService(navigationService);
        }

        public void SetNavigationService(INavigationService navigationService)
        {
            MyHamburgerMenu.NavigationService = navigationService;
            HamburgerMenu.RefreshStyles(_settings.AppTheme, true);
            HamburgerMenu.IsFullScreen = _settings.IsFullScreen;
            HamburgerMenu.HamburgerButtonVisibility = _settings.ShowHamburgerButton ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
