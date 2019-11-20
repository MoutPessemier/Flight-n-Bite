using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Flight__n_Bite.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<OrderLine> NewOrderLines { get; set; }
        public Visibility _newOrderLineVisible { get; private set; }
        private HttpService httpService = HttpService.instance;
        public event PropertyChangedEventHandler PropertyChanged;

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
            Orders = new ObservableCollection<Order>();
            NewOrderLines = new ObservableCollection<OrderLine>();
            LoadFoodsDrinks();
            LoadOrders();
        }

        private async void LoadFoodsDrinks()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/product"));
            IList<Product> productList = JsonConvert.DeserializeObject<ObservableCollection<Product>>(json);

            foreach (var p in productList)
            {
                Products.Add(p);
            }
        }

        private async void LoadOrders()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/order"));
            IList<Order> orderList = JsonConvert.DeserializeObject<ObservableCollection<Order>>(json);

            foreach (var o in orderList)
            {
                Orders.Add(o);
            }
        }

        public void AddOrderLine(OrderLine newOrderLine)
        {
            NewOrderLines.Add(newOrderLine);
            OnPropertyChanged("NewOrderlines");
        }

        public void DeleteOrderLine(OrderLine newOrderLine)
        {
            NewOrderLines.Remove(newOrderLine);
            OnPropertyChanged("NewOrderlines");
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("NewOrderlines"))
            {
                if (NewOrderLines.Count == 0)
                {
                    _newOrderLineVisible = Visibility.Collapsed;
                }
                else
                {
                    _newOrderLineVisible = Visibility.Visible;
                }
            }

            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
