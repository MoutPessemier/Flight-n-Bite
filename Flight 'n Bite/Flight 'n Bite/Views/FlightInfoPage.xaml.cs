using Windows.UI.Xaml.Controls;

namespace Flight__n_Bite.Views
{
    public sealed partial class FlightInfoPage : Page
    {
        public FlightInfoPage()
        {
            InitializeComponent();
            map.MapServiceToken = "USFEOxkmSWLfzImVMywC~5ACMQ_yNXy2whn0cMKQYFw~Avs5Y7C-hzkmDAj0s8uJx536bGKYMHTjrri6acyzzPoIcT8QS2D_NcSefaAk4cK1";
            vm1.Map = map;
        }
    }
}
