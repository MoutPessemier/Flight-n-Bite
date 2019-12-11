using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flight__n_Bite.Models
{
    public class Product : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string _name { get; set; }
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private double _price { get; set; }
        public double Price {
            get {
                return _price;
            }
            set {
                _price = value;
                OnPropertyChanged("Price");
            }
        }
        private string _description { get; set; }
        public string Description {
            get {
                return _description;
            }
            set {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        private int _discount { get; set; }
        public int Discount {
            get {
                return _discount;
            }
            set {
                _discount = value;
                OnPropertyChanged("Discount");
            }
        }

        public Product()
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
