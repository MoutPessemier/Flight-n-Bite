﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

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

            var username = Application.Current.Resources["WeatherAPI_username"];
            var password = Application.Current.Resources["WeatherAPI_password"];

            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));

            _weatherhttpClient = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = authValue }
            };

        }

        public async Task<string> GetStringAsync(Uri uri)
        {
            return await _httpClient.GetStringAsync(uri);
        }


        public async Task<string> GetWeatherAsync(Uri uri)
        {
            return await _weatherhttpClient.GetStringAsync(uri);
        }

        public async Task<string> PostAsync(string uri, StringContent content)
        {
            var res = await _httpClient.PostAsync(uri, content);
            return await res.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteByIdAsync(string uri, int id)
        {
            var res = await _httpClient.DeleteAsync(uri + id);
            return await res.Content.ReadAsStringAsync();
        }
    }
}
