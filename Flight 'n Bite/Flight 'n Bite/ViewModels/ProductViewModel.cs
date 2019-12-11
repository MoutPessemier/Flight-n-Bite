using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Flight__n_Bite.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml;

namespace Flight__n_Bite.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<OrderLine> NewOrderLines { get; set; }
        public Visibility NewOrderLineVisible { get; private set; }
        private readonly HttpService HttpService = HttpService.instance;
        public double TotalCost {
            get {
                return _totalCost;
            }
            set {
                _totalCost = value;
                OnPropertyChanged("TotalCost");
            }
        }
        private double _totalCost { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private int _newAmount { get; set; }
        public int NewAmount {
            get {
                return _newAmount;
            }
            set {
                _newAmount = value;
                OnPropertyChanged("NewAmount");
            }
        }
        public ProductViewModel()
        {
            NewOrderLineVisible = Visibility.Collapsed;
            Products = new ObservableCollection<Product>();
            Orders = new ObservableCollection<Order>();
            NewOrderLines = new ObservableCollection<OrderLine>();
            _newAmount = 1;
            _totalCost = 0;
            LoadFoodsDrinks();
            LoadOrders();
        }

        private async void LoadFoodsDrinks()
        {
            string json = await HttpService.GetStringAsync(new Uri("http://localhost:49527/api/product"));
            IList<Product> productList = JsonConvert.DeserializeObject<ObservableCollection<Product>>(json);

            foreach (var p in productList)
            {
                Products.Add(p);
            }
        }

        private async void LoadOrders()
        {
            string json = null;
            if (Shell.Passenger != null)
            {
                json = await HttpService.GetStringAsync(new Uri("http://localhost:49527/api/order/getByPassengerId/" + Shell.Passenger.Id));
            }
            else
            {
                json = await HttpService.GetStringAsync(new Uri("http://localhost:49527/api/order"));
            }
            IList<Order> orderList = JsonConvert.DeserializeObject<ObservableCollection<Order>>(json);

            foreach (var o in orderList)
            {
                Orders.Add(o);
            }
        }

        public async void AddOrderLine(OrderLine newOrderLine)
        {
            string newOrderLinejson = JsonConvert.SerializeObject(newOrderLine);
            string json = await HttpService.PostAsync("http://localhost:49527/api/orderLine/addOrderLine", new StringContent(newOrderLinejson, Encoding.UTF8, "application/json"));
            OrderLine orderLineWithId = JsonConvert.DeserializeObject<OrderLine>(json);
            NewOrderLines.Add(orderLineWithId);

            double Normalprice = orderLineWithId.Amount * orderLineWithId.Product.Price;
            TotalCost += Normalprice - Normalprice / 100 * orderLineWithId.Product.Discount;

            OnPropertyChanged("NewOrderLineVisible");
        }

        public async void DeleteOrderLine(int id)
        {
            await HttpService.DeleteByIdAsync("http://localhost:49527/api/orderLine/deleteOrderLine/", id);
            OrderLine deleteOrderLine = NewOrderLines.FirstOrDefault(ol => ol.Id == id);
            NewOrderLines.Remove(deleteOrderLine);

            double Normalprice = deleteOrderLine.Amount * deleteOrderLine.Product.Price;
            TotalCost -= Normalprice - Normalprice / 100 * deleteOrderLine.Product.Discount;

            OnPropertyChanged("NewOrderLineVisible");
        }

        public async void AddOrder(Order newOrder)
        {
            if (NewOrderLines.Count() > 0)
            {
                newOrder.IsHandled = false;
                string newOrderjson = JsonConvert.SerializeObject(newOrder);
                string json = await HttpService.PostAsync("http://localhost:49527/api/order/addOrder", new StringContent(newOrderjson, Encoding.UTF8, "application/json"));
                Order orderWithId = JsonConvert.DeserializeObject<Order>(json);
                Orders.Add(orderWithId);
                NewOrderLines.Clear();
                _newAmount = 1;
                _totalCost = 0;
                OnPropertyChanged("NewOrder");
                OnPropertyChanged("NewOrderLineVisible");
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("NewOrderLineVisible"))
            {
                if (NewOrderLines.Count == 0)
                {
                    NewOrderLineVisible = Visibility.Collapsed;
                }
                else
                {
                    NewOrderLineVisible = Visibility.Visible;
                }
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
