using Flight__n_Bite.Models;
using System;
using Template10.Services.NavigationService;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Flight__n_Bite.Views
{
    public sealed partial class ContentPage : Page
    {
        public ContentPage()
        {
            InitializeComponent();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as Movie;
            var Nav = NavigationService.GetForFrame(Frame);
            Nav.Navigate(typeof(MoviesOverview), item);

        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as Music;
            musicPlayer.Source = MediaSource.CreateFromUri(new Uri($"ms-appx:///Assets/Music/{item.Artist.Name}-{item.Title}.mp3"));
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            musicPlayer.Source = null;
        }
    }
}
