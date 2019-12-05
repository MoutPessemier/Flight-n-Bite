using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Flight__n_Bite.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonnelMessagePage : Page
    {
        public PersonnelMessagePage()
        {
            this.InitializeComponent();
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
