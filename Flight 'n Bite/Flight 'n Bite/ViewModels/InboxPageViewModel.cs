using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Flight__n_Bite.ViewModels
{
    public class InboxPageViewModel
    {
        private readonly HttpService httpService = HttpService.instance;
        public ObservableCollection<PersonnelMessage> Messages { get; set; }

        public InboxPageViewModel()
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
    }
}
