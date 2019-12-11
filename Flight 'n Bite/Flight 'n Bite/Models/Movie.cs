using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    public class Movie : INotifyPropertyChanged
    {
        #region Fields        
        private string _title;
        private string _description;
        private double _rating;
        private string _posterUri;
        private IList<Artist> _cast;
        private string _director;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Description {
            get {
                return _description;
            }
            set {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public double Rating {
            get {
                return _rating;
            }
            set {
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }
        public string PosterUri {
            get {
                return _posterUri;
            }
            set {
                _posterUri = value;
                OnPropertyChanged("PosterUri");
            }
        }
        public IList<Artist> Cast {
            get {
                return _cast;
            }
            set {
                _cast = value;
                OnPropertyChanged("Cast");
            }
        }
        public string Director {
            get {
                return _director;
            }
            set {
                _director = value;
                OnPropertyChanged("Director");
            }
        }
        #endregion

        public Movie()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
