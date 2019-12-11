using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Flight__n_Bite.Models.DTO;
using Flight__n_Bite.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace Flight__n_Bite.ViewModels
{
    public class PersonnelMessagePageViewModel
    {
        private readonly HttpService httpService = HttpService.instance;
        public ObservableCollection<PersonnelMessage> Messages { get; set; }

        public PersonnelMessagePageViewModel()
        {
            Messages = new ObservableCollection<PersonnelMessage>();
            LoadMessages();
        }

        private async void LoadMessages()
        {
            var json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/personnel/getMessages"));
            List<PersonnelMessage> list = JsonConvert.DeserializeObject<List<PersonnelMessage>>(json);
            foreach (var m in list)
            {
                Messages.Add(m);
            }
        }

        public async void SendMessage(PersonnelMessage message)
        {
            var mes = new PersonnelMessageDTO() { Email = Shell.Personnel.Username, Message = message };
            string messageJson = JsonConvert.SerializeObject(mes);
            var json = await httpService.PostAsync("http://localhost:49527/api/personnel/AddMessage", new StringContent(messageJson, Encoding.UTF8, "application/json"));
            try
            {
                var m = JsonConvert.DeserializeObject<PersonnelMessage>(json);
                Messages.Add(m);
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
        }
    }
}
