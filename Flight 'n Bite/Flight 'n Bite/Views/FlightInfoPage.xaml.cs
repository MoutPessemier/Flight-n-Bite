using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class FlightInfoPage : Page
    {
        public FlightInfoPage()
        {
            this.InitializeComponent();
            map.MapServiceToken = "USFEOxkmSWLfzImVMywC~5ACMQ_yNXy2whn0cMKQYFw~Avs5Y7C-hzkmDAj0s8uJx536bGKYMHTjrri6acyzzPoIcT8QS2D_NcSefaAk4cK1";
            vm1.Map = map;
        }
    }
}
