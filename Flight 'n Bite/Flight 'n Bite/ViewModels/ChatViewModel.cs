using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Flight__n_Bite.Models.DTO;
using Flight__n_Bite.Views;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml;

namespace Flight__n_Bite.ViewModels
{
    public class ChatViewModel
    {
        HttpService httpService = HttpService.instance;
        public ObservableCollection<Passenger> Companions { get; set; }
        public ObservableCollection<Message> Chat { get; set; }
        public Group Group { get; set; }

        private bool _groupAvailable;
        public bool GroupAvailable {
            get {
                return _groupAvailable;
            }
            set {
                _groupAvailable = value;
                OnPropertyChanged("GroupAvailable");
            }
        }

        public ChatViewModel()
        {
            _groupAvailable = false;
            Companions = new ObservableCollection<Passenger>();
            Chat = new ObservableCollection<Message>();
            LoadCompanions();
            LoadChat();
        }

        private async void LoadCompanions()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/group/" + Shell.Passenger.Id));
            Group group = JsonConvert.DeserializeObject<Group>(json);
            if (group != null)
            {
                Group = group;
                _groupAvailable = true;
                foreach (var c in group.Companions)
                {
                    Companions.Add(c);
                }
            }

        }

        private async void LoadChat()
        {
            string json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/group/" + Shell.Passenger.Id));
            Group group = JsonConvert.DeserializeObject<Group>(json);
            if (group != null)
            {
                foreach (var m in group.Chat)
                {
                    if (m.Passenger.Id == Shell.Passenger.Id)
                    {
                        m.Alignment = HorizontalAlignment.Right;
                    }
                    Chat.Add(m);
                }
            }
        }

        public async void SendMessage(MessageDTO message)
        {
            string messageJson = JsonConvert.SerializeObject(message);
            var json = await httpService.PostAsync("http://localhost:49527/api/group/sendMessage", new StringContent(messageJson, Encoding.UTF8, "application/json"));
            try
            {
                var m = JsonConvert.DeserializeObject<Message>(json);
                if (m.Passenger.Id == Shell.Passenger.Id)
                {
                    m.Alignment = HorizontalAlignment.Right;
                }
                Chat.Add(m);
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}