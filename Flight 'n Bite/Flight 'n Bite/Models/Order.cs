using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    public class Order : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private Passenger _passenger { get; set; }
        private bool _ishandled { get; set; }

        public bool IsHandled {
            get {
                return _ishandled;
            }
            set {
                _ishandled = value;
                OnPropertyChanged("IsHandled");
            }
        }
        public Passenger Passenger {
            get {
                return _passenger;
            }
            set {
                _passenger = value;
                OnPropertyChanged("Passenger");
            }
        }
        private List<OrderLine> _orderLines { get; set; }
        public List<OrderLine> OrderLines {
            get {
                return _orderLines;
            }
            set {
                _orderLines = value;
                OnPropertyChanged("Orderlines");
            }
        }

        public Order()
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
