using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Flight__n_Bite.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        Services.SettingsServices.SettingsService _settings;

        public Login()
        {
            this.InitializeComponent();
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                // designtime
            }
            else
            {
                _settings = Services.SettingsServices.SettingsService.Instance;
            }
            _settings.IsFullScreen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txbValidationLabel.Text = "";
            txbValidationLabel.Visibility = Visibility.Collapsed;
            txbNameValidation.Text = "";
            txbNameValidation.Visibility = Visibility.Collapsed;
            var seatNumber = txbSeatNumber.Text;
            Regex regEx = new Regex(@"\w\d{1,3}");
            if (!regEx.Match(seatNumber).Success)
            {
                txbValidationLabel.Visibility = Visibility.Visible;
                txbValidationLabel.Text = "Wrong format. Format is X00.";
            }
            if (string.IsNullOrEmpty(txbFirstName.Text) || string.IsNullOrEmpty(txbLastName.Text) || string.IsNullOrWhiteSpace(txbFirstName.Text) || string.IsNullOrWhiteSpace(txbLastName.Text))
            {
                txbNameValidation.Visibility = Visibility.Visible;
                txbNameValidation.Text = "First or last name cannot be empty";
            }
            if (string.IsNullOrEmpty(txbNameValidation.Text) && string.IsNullOrEmpty(txbValidationLabel.Text))
            {
                HandlePassengerLogin();

            }
        }

        private async void HandlePassengerLogin()
        {
            var currentPassenger = await LoginPassenger(new Passenger() { SeatIdentifier = txbSeatNumber.Text, FirstName = txbFirstName.Text, LastName = txbLastName.Text });

            if (currentPassenger != null && currentPassenger.FirstName != null)
            {
                _settings.IsFullScreen = false;
                _settings.IsPersonnel = false;
                Shell.Passenger = currentPassenger;
                Frame.Navigate(typeof(FlightInfoPage));

            }
            else
            {
                txbValidationLabel.Visibility = Visibility.Visible;
                txbValidationLabel.Text = "Firstname,lastname and seat doesn't match";
            }


        }

        private async Task<Passenger> LoginPassenger(Passenger passenger)

        {
            HttpService httpService = HttpService.instance;
            string currentPassengerjson = JsonConvert.SerializeObject(passenger);
            var json = await httpService.PostAsync("http://localhost:49527/api/passenger/login", new StringContent(currentPassengerjson, Encoding.UTF8, "application/json"));
            try
            {
                return JsonConvert.DeserializeObject<Passenger>(json);

            }
            catch
            {
                return null;
            }

        }

        private void Button_Click_Personnel(object sender, RoutedEventArgs e)
        {
            txbPersonnelValidation.Visibility = Visibility.Collapsed;
            if (string.IsNullOrEmpty(txbPersonnelUserName.Text) || string.IsNullOrWhiteSpace(txbPersonnelUserName.Text) || string.IsNullOrEmpty(pswPasswordBox.Text) || string.IsNullOrWhiteSpace(pswPasswordBox.Text))
            {
                txbPersonnelValidation.Text = "Username or password cannot be empty";
                txbPersonnelValidation.Visibility = Visibility.Visible;

            }
            HandleLoginPersonnel();

        }

        private async void HandleLoginPersonnel()
        {
            var personnel = await LoginPersonnel(txbPersonnelUserName.Text, pswPasswordBox.Text);
            if (personnel != null && personnel.Username != null)
            {
                _settings.IsFullScreen = false;
                _settings.IsPersonnel = true;
                Shell.Personnel = personnel;
                Frame.Navigate(typeof(PassengersOverviewPage));
            }
            else
            {
                txbPersonnelValidation.Text = "Username or password are wrong";
                txbPersonnelValidation.Visibility = Visibility.Visible;

            }
        }

        private async Task<Personnel> LoginPersonnel(string username, string password)
        {
            HttpService httpService = HttpService.instance;

            string personneljson = JsonConvert.SerializeObject(new PersonnelLoginDTO() { UserName = username, Password = password });

            var json = await httpService.PostAsync("http://localhost:49527/api/personnel/login", new StringContent(personneljson, Encoding.UTF8, "application/json"));

            try
            {
                return JsonConvert.DeserializeObject<Personnel>(json);

            }
            catch
            {
                return null;
            }
        }

        private void Toggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggle.IsOn)
            {
                PersonnelLogin.Visibility = Visibility.Visible;
                PassengerLogin.Visibility = Visibility.Collapsed;
            }
            else
            {
                PersonnelLogin.Visibility = Visibility.Collapsed;
                PassengerLogin.Visibility = Visibility.Visible;
            }
        }
    }
}