using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Flight__n_Bite.ViewModels
{
    public class ContentPageViewModel
    {
        public ObservableCollection<Music> MusicList { get; set; }
        public ObservableCollection<Movie> MovieList { get; set; }

        private readonly HttpService httpService = HttpService.instance;

        public ContentPageViewModel()
        {
            MusicList = new ObservableCollection<Music>();
            MovieList = new ObservableCollection<Movie>();
            loadMovies();
            loadMusic();
        }

        private async void loadMovies()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/movie"));
            IList<Movie> movies = JsonConvert.DeserializeObject<IList<Movie>>(json);
            foreach (var m in movies)
            {
                MovieList.Add(m);
            }
        }


        private async void loadMusic()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/music"));
            IList<Music> music = JsonConvert.DeserializeObject<IList<Music>>(json);
            foreach (var m in music)
            {
                MusicList.Add(m);
            }
        }
    }
}
