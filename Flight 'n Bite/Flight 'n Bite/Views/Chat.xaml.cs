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
            if(vm.Group == null)
            {
                sendBtn.IsEnabled = false;
                messageBody.IsEnabled = false;
                messageBody.Text = "You don't have a group to chat with.";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var message = new MessageDTO() { Body = messageBody.Text, Passenger = Shell.Passenger };
            vm.SendMessage(message);
            messageBody.Text = "";
        }
    }
}
