using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Flight__n_Bite.Models;

namespace Flight__n_Bite.data
{
    public class HttpService
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClient _weatherhttpClient;


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

            //Nu leeg gelaten --> Waar Users screts in Universal Windows??
            var username = ""; var password = "";

            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));

            _weatherhttpClient = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = authValue }

            };

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


        public async Task<string> GetWeatherAsync(Uri uri)
        {
            string json = await _weatherhttpClient.GetStringAsync(uri);
            return json;
        }

    }
}
