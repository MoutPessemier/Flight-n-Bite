using Flight__n_Bite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Flight__n_Bite.ViewModels
{
    public class FoodsDrinksPageViewModel : ViewModelBase
    {
        private readonly List<Order> _ordersFromPassenger;
        public List<Product> products 
        public FoodsDrinksPageViewModel(List<Order> orders)
        {
            _ordersFromPassenger = orders;
        }


    }
}
