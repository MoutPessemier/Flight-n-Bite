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
            LoadFoodsDrinks();
            LoadOrders();
        }

        private async void LoadFoodsDrinks()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/product"));
            Products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(json);
        }

        private async void LoadOrders()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/order"));
            Orders = JsonConvert.DeserializeObject<ObservableCollection<Order>>(json);
        }

        public async Task<string> getProductNameAsync(int productId)
        {
            string json = await httpService.GetStringAsync(new Uri($"http://localhost:49527/api/product/{productId}"));
            Product product = JsonConvert.DeserializeObject<Product>(json);
            return product.Name;
        }
    }
}
