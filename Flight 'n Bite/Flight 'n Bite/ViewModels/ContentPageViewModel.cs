using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    class ContentPageViewModel
    {
        public ObservableCollection<Music> MusicList { get; set; }
        public ObservableCollection<Movie> MovieList { get; set; }
    }
}
