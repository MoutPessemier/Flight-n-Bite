using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class Day: INotifyPropertyChanged
    {
        #region Properties
        [JsonProperty("date")]
        private string _date;
        public string Date {
            get {
                return _date;
            }
            set {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        [JsonProperty("value")]
        private double _temperature;
        public double Temperature {
            get {
                return _temperature;
            }
            set {
                _temperature = value;
                OnPropertyChanged("Temperature");
            }
        }
        #endregion

        public Day()
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
