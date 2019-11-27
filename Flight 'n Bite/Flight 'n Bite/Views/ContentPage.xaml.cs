using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using Template10.Services.NavigationService;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Flight__n_Bite.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContentPage : Page
    {
        public ContentPage()
        {
            this.InitializeComponent();
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
