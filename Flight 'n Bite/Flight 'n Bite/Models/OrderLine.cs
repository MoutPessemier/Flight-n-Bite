using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    public class OrderLine : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private Product _product { get; set; }
        public Product Product {
            get {
                return _product;
            }
            set {
                _product = value;
                OnPropertyChanged("Product");
            }
        }
        private int _amount { get; set; }
        public int Amount {
            get {
                return _amount;
            }
            set {
                _amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public OrderLine()
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
