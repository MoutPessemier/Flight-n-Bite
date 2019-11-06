using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class Order : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private Passenger _passenger { get; set; }
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
