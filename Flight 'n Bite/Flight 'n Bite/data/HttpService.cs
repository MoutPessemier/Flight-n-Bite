using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flight__n_Bite.Models;

namespace Flight__n_Bite.data
{
    public class HttpService
    {
        private readonly HttpClient _httpClient;
        private static HttpService _instance;

        public static HttpService instance {
            get {
                if (_instance == null)
                {
                    _instance = new HttpService();
                }
                return _instance;
            }
        }
        private HttpService()
        {
            _httpClient = new HttpClient();
        }

        internal ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>() { new Product() { Id = 1, Name = "test", Description = "dit is een test", Price = 100 } };
        }

        public async Task<string> GetStringAsync(Uri uri)
        {
            string json = await _httpClient.GetStringAsync(uri);
            return json;
        }
    }
}
