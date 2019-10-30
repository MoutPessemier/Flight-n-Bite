using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Flight__n_Bite.ViewModels
{
    public class FoodsDrinksPageViewModel : ViewModelBase
    {
        private readonly List<Order> _ordersFromPassenger;
        public ObservableCollection<Product> Products { get; set; }
        private HttpService _httpService;
        public FoodsDrinksPageViewModel(List<Order> orders)
        {
            _ordersFromPassenger = orders;
            _httpService = HttpService.instance;
            Products = _httpService.GetProducts();
        }

        public FoodsDrinksPageViewModel()
        {
            _ordersFromPassenger = new List<Order>();
            _httpService = HttpService.instance;
            Products = _httpService.GetProducts();
        }

    }
}
