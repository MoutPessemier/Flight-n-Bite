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
        public OrderLine _newOrderLine { get; set; }
        public Visibility _newOrderLineVisible { get; private set; }
        private HttpService httpService = HttpService.instance;
        public event PropertyChangedEventHandler PropertyChanged;
        public OrderLine NewOrderLine {
            get {
                return _newOrderLine;
            }
            set {
                _newOrderLine = value;
                OnPropertyChanged("NewOrderline");
            }
        }

        public Visibility NewOrderLineVisible {
            get {
                return _newOrderLineVisible;
            }
            set {
                _newOrderLineVisible = value;
                OnPropertyChanged("NewOrderLineVisible");
            }
        }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
            Orders = new ObservableCollection<Order>();
            NewOrderLine = new OrderLine() { Amount = 1 };
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

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("NewOrderline"))
            {
                if (_newOrderLine.Product == null)
                {
                    NewOrderLineVisible = Visibility.Collapsed;
                }
                else
                {
                    NewOrderLineVisible = Visibility.Visible;
                }
            }

            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //<Image/>
        //               <Grid>
        //                   <Grid.ColumnDefinitions>
        //                       <ColumnDefinition/>
        //                   </Grid.ColumnDefinitions>
        //                   <Grid.RowDefinitions>
        //                       <RowDefinition/>
        //                       <RowDefinition/>
        //                       <RowDefinition/>
        //                   </Grid.RowDefinitions>
        //                   <TextBlock Grid.Row="0" Grid.Column= "0" x:Name= "name" FontSize= "32" Text= "test" />
        //                   < TextBlock Grid.Row= "1" Grid.Column= "0" x:Name= "description" FontSize= "12" Text= "test" />
        //                   < TextBlock Grid.Row= "2" Grid.Column= "0" x:Name= "price" FontFamily= "24" Text= "test" />
        //               </ Grid >
    }
}
