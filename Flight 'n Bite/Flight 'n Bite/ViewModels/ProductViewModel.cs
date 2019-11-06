using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Flight__n_Bite.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        private HttpService httpService = HttpService.instance;

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
            Orders = new ObservableCollection<Order>();
            LoadFoodsDrinks();
            LoadOrders();
        }

        private async void LoadFoodsDrinks()
        { 
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/product"));
            IList<Product> productList = JsonConvert.DeserializeObject<ObservableCollection<Product>>(json);

            foreach(var p in productList)
            {
                Products.Add(p);
            }
        }

        private async void LoadOrders()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/order"));
            IList<Order> orderList = JsonConvert.DeserializeObject<ObservableCollection<Order>>(json);

            foreach(var o in orderList)
            {
                Orders.Add(o);
            }
        }
    }
}
