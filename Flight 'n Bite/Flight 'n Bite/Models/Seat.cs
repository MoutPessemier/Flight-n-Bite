using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class Seat : INotifyPropertyChanged
    {

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
