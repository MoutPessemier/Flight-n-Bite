using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    public class Day : INotifyPropertyChanged
    {
        #region Properties
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
        private double _cloudCover;

        public double CloudCover {
            get {
                return _cloudCover;
            }
            set {
                _cloudCover = value;
                OnPropertyChanged("CloudCover");
            }
        }
        private double _rainWater;

        public double RainWater {
            get {
                return _rainWater;
            }
            set {
                _rainWater = value;
                OnPropertyChanged("RainWater");
            }
        }
        #endregion

        public Day()
        {

        }
        public string CurrentWeather {
            get {
                if (RainWater > 50)
                    return "Rainy";
                if (CloudCover > 50)
                {
                    return "Cloudy";
                }
                return "Sunny";
            }
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
