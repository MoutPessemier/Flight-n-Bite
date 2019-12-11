using Flight__n_Bite.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.ViewModels
{
    public class MovieOverviewViewModel : INotifyPropertyChanged
    {
        private Movie _movie;
        public Movie Movie {
            get {
                return _movie;
            }
            set {
                _movie = value;
                OnPropertyChanged("Movie");
            }
        }
        public MovieOverviewViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
