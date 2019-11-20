using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Artist: INotifyPropertyChanged
    {
        #region Fields
        private string _name;
        #endregion

        #region Properties
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        #endregion

        public Artist()
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
