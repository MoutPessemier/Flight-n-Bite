using Flight__n_Bite.Models.DTO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Flight__n_Bite.Views
{
    public sealed partial class Chat : Page
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDTO() { Body = messageBody.Text, Passenger = Shell.Passenger };
            vm.SendMessage(message);
            messageBody.Text = "";
        }
    }
}
