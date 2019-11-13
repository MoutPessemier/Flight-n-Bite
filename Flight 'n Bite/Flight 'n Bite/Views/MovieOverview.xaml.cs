using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
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
    public sealed partial class MovieOverview : Page
    {
        public MovieOverview()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var Movie = (Movie)e.Parameter;

            //var s = e.Parameter as string;
            //vm.Movie = e.Parameter as string;
          //  SetSource();
        }

        private void SetSource()
        {
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri($"ms-appx:///Assets/Movies/{vm.Movie.Title}.mp4"));
        }


    }
}
