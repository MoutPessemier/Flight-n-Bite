using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;

namespace Flight__n_Bite.ViewModels
{
    class DiscountViewmodel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        private readonly HttpService HttpService = HttpService.instance;

        public event PropertyChangedEventHandler PropertyChanged;

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

        public Product currentProduct { get; internal set; }

        public DiscountViewmodel()
        {
            Products = new ObservableCollection<Product>();
            LoadFoodsDrinks();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        public async void UpdateDiscount()
        {
            currentProduct.Discount = Discount;
            string productJson = JsonConvert.SerializeObject(currentProduct);
            await HttpService.PostAsync("http://localhost:49527/api/product", new StringContent(productJson, Encoding.UTF8, "application/json"));
            Products.FirstOrDefault(p => p.Id == currentProduct.Id).Discount = Discount;
        }
    }
}
