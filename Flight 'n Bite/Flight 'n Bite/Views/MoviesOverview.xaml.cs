using Flight__n_Bite.Models;
using System;
using Template10.Services.SerializationService;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Flight__n_Bite.Views
{
    public sealed partial class MoviesOverview : Page
    {
        public MoviesOverview()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            vm.Movie = SerializationService.Json.Deserialize<Movie>(e.Parameter.ToString());
            SetSource();
        }

        private void SetSource()
        {
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri($"ms-appx:///Assets/Movies/{vm.Movie.Title}.mp4"));
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            mediaPlayer.Source = null;
        }
    }
}
