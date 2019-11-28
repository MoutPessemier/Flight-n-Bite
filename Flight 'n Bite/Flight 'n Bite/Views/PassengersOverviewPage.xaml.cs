using Flight__n_Bite.data;
using Flight__n_Bite.Model.DTO;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PassengersOverviewPage : Page
    {
        public PassengersOverviewPage()
        {
            this.InitializeComponent();
        }
        private async void handleSwitchSeats(IList<object> items)
        {
            if (items.Count == 2)
            {
                var passengerseat1 = ((PassengerSeat)items[0]);
                var passengerseat2 = ((PassengerSeat)items[1]);
                var p1seat = passengerseat1.Seat.Number;
                var p2seat = passengerseat2.Seat.Number;
                if (passengerseat1.Passenger != null)
                    passengerseat1.Passenger.SeatIdentifier = p2seat;
                if (passengerseat2.Passenger != null)
                    passengerseat2.Passenger.SeatIdentifier = p1seat;

                HttpService httpService = HttpService.instance;

                string personneljson = JsonConvert.SerializeObject(new SwitchsSeatsDTO() { Passenger1 = passengerseat1.Passenger, Passenger2 = passengerseat2.Passenger });

                var json = await httpService.PostAsync("http://localhost:49527/api/passenger/switchSeats", new StringContent(personneljson, Encoding.UTF8, "application/json"));
                var success = JsonConvert.DeserializeObject<Boolean>(json);
                if (success)
                    vm.refreshSeats();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            handleSwitchSeats(grid.SelectedItems);

        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gv = (GridView)sender;
            if (sender == null || gv.SelectedItems.Count > 2)
            {
                gv.SelectedItems.Remove(gv.SelectedItems[0]);
            }
        }
    }
}