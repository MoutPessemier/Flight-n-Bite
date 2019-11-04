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
    public class FoodsDrinksViewModel : ViewModelBase
    {
        public ObservableCollection<Product> Products { get; set; }

        public FoodsDrinksViewModel()
        {
            LoadFoodsDrinks();
        }

        private async void LoadFoodsDrinks()
        {
            HttpService httpService = HttpService.instance;
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/products"));
            Products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(json);
        }
    }
}
