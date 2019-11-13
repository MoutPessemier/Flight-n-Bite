using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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
                var currentUser = new Passenger() { SeatIdentifier = txbSeatNumber.Text, FirstName = txbFirstName.Text, LastName = txbLastName.Text };
                _settings.IsFullScreen = false;
                Frame.Navigate(typeof(FlightInfoPage));
            }
        }

        private void Button_Click_Personnel(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPersonnelUserName.Text) || string.IsNullOrWhiteSpace(txbPersonnelUserName.Text) || string.IsNullOrEmpty(pswPasswordBox.Text) || string.IsNullOrWhiteSpace(pswPasswordBox.Text))
            {
                txbPersonnelValidation.Text = "Username or password cannot be empty";
            }
            var isLoggedIn = LoginPersonnel(txbPersonnelUserName.Text, pswPasswordBox.Text);
            if (isLoggedIn)
            {
                _settings.IsFullScreen = false;
                Frame.Navigate(typeof(FlightInfoPage));
            }
        }

        private bool LoginPersonnel(string username, string password)
        {
            return false;
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
