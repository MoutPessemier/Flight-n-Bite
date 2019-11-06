using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class Weather : INotifyPropertyChanged
    {
        #region Properties
        public int Id { get; set; }
        private ObservableCollection<Day> _dates;
        public ObservableCollection<Day> Dates {
            get {
                return _dates;
            }
            set {
                _dates = value;
                OnPropertyChanged("Dates");
            }
        }
        #endregion
        public Weather()
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
