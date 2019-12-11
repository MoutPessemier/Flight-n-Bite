using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Flight__n_Bite.Models;

namespace Flight__n_Bite.Views
{
    public sealed partial class PersonnelMessagePage : Page
    {
        public PersonnelMessagePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var body = messageBody.Text;
            if (!string.IsNullOrEmpty(body))
            {
                PersonnelMessage message = new PersonnelMessage() { Body = body };
                vm.SendMessage(message);
                messageBody.Text = "";
            }
        }
    }
}
