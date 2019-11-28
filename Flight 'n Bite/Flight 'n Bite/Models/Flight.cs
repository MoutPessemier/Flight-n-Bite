using Flight_n_Bite_API.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class Flight : INotifyPropertyChanged
    {
        #region Properties
        public int Id { get; set; }
        private string _number;
        public string Number {
            get {
                return _number;
            }
            set {
                _number = value;
                OnPropertyChanged("Number");
            }
        }
        private string _departure;
        public string Departure {
            get {
                return _departure;
            }
            set {
                _departure = value;
                OnPropertyChanged("Departure");
            }
        }

        private string _arrival;
        public string Arrival {
            get {
                return _arrival;
            }
            set {
                _arrival = value;
                OnPropertyChanged("Arrival");
            }
        }
        private IList<Seat> _seats;
        public IList<Seat> Seats {
            get {
                return _seats;
            }
            set {
                _seats = value;
                OnPropertyChanged("Seats");
            }
        }
        private double _startLatitude;
        public double StartLatitude {
            get {
                return _startLatitude;
            }
            set {
                _startLatitude = value;
                OnPropertyChanged("StartLatitude");
            }
        }
        private double _startLongitude;
        public double StartLongitude {
            get {
                return _startLongitude;
            }
            set {
                _startLongitude = value;
                OnPropertyChanged("StartLongitude");
            }
        }

        private double _endLatitude;
        public double EndLatitude {
            get {
                return _endLatitude;
            }
            set {
                _endLatitude = value;
                OnPropertyChanged("EndLatitude");
            }
        }
        private double _endLongitude;
        public double EndLongitude {
            get {
                return _endLongitude;
            }
            set {
                _endLongitude = value;
                OnPropertyChanged("EndLongitude");
            }
        }
        private double _duration;
        public double Duration {
            get {
                return _duration;
            }
            set {
                _duration = value;
                OnPropertyChanged("Duration");
            }
        }
        private double _departureTime;
        public double DepartureTime {
            get {
                return _departureTime;
            }
            set {
                _departureTime = value;
                OnPropertyChanged("DepartureTime");
            }
        }
        private double _delay;
        public double Delay {
            get {
                return _endLongitude;
            }
            set {
                _delay = value;
                OnPropertyChanged("Delay");
            }
        }

        #endregion
        public Flight()
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
