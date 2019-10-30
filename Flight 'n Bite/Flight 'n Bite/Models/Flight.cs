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
