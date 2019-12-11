using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    public class Music : INotifyPropertyChanged
    {
        #region Fields
        private string _title;
        private Artist _artist;
        private string _album;
        private string _coverUri;
        private IList<Artist> _coArtists;
        #endregion

        #region Properties
        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        public Artist Artist {
            get {
                return _artist;
            }
            set {
                _artist = value;
                OnPropertyChanged("Artist");
            }
        }
        public string Album {
            get {
                return _album;
            }
            set {
                _album = value;
                OnPropertyChanged("Album");
            }
        }
        public string CoverUri {
            get {
                return _coverUri;
            }
            set {
                _coverUri = value;
                OnPropertyChanged("CoverUri");
            }
        }
        public IList<Artist> CoArtists {
            get {
                return _coArtists;
            }
            set {
                _coArtists = value;
                OnPropertyChanged("CoArtists");
            }
        }
        #endregion

        public Music()
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
