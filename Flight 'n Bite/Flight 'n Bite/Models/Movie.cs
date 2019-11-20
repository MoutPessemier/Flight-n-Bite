using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    [JsonObject(MemberSerialization.OptIn)]
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
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        [JsonProperty]
        public string Description {
            get {
                return _description;
            }
            set {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        [JsonProperty]
        public double Rating {
            get {
                return _rating;
            }
            set {
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }
        [JsonProperty]
        public string PosterUri {
            get {
                return _posterUri;
            }
            set {
                _posterUri = value;
                OnPropertyChanged("PosterUri");
            }
        }
        [JsonProperty]
        public IList<Artist> Cast {
            get {
                return _cast;
            }
            set {
                _cast = value;
                OnPropertyChanged("Cast");
            }
        }
        [JsonProperty]
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
