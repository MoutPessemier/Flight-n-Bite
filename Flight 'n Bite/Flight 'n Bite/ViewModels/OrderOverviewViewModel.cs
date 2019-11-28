using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    class OrderOverviewViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders { get; set; }
        private readonly HttpService HttpService = HttpService.instance;

        public event PropertyChangedEventHandler PropertyChanged;

        public OrderOverviewViewModel()
        {
            Orders = new ObservableCollection<Order>();
            LoadOrders();
        }

        private async void LoadOrders()
        {
            string json = json = await HttpService.GetStringAsync(new Uri("http://localhost:49527/api/order"));

            IList<Order> orderList = JsonConvert.DeserializeObject<ObservableCollection<Order>>(json).OrderBy(o => o.IsHandled).ToList();

            foreach (var o in orderList)
            {
                Orders.Add(o);
            }
        }

        public async void HandleOrder(Order order)
        {
            string orderjson = JsonConvert.SerializeObject(order);
            await HttpService.PostAsync("http://localhost:49527/api/order/handleOrder", new StringContent(orderjson, Encoding.UTF8, "application/json"));
            Orders.FirstOrDefault(o => o.Id == order.Id).IsHandled = true;
            // httpservice post request voor handeling order en in backend ook toevoegen aan controller en repo
        }
    }
}
