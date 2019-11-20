using Flight__n_Bite.Models;
using System;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;

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
            // TODO: fix this navigation
             Frame.Navigate(typeof(MovieOverview), item);
            //Frame.Navigate(typeof(MovieOverview));

        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as Music;
            // TODO: fix media player
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri($"ms-appx:///Assets/Music/{item.Artist.Name} - {item.Title}.mp3"));

        }
    }
}
