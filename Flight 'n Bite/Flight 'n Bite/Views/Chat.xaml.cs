using Flight__n_Bite.Models;
using Flight__n_Bite.Models.DTO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Chat : Page
    {
        public Chat()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDTO() { Body = messageBody.Text, Passenger = Shell.Passenger };
            vm.SendMessage(message);
            messageBody.Text = "";
        }
    }
}
