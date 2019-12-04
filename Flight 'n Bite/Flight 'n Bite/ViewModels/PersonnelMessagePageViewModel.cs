using Flight__n_Bite.data;
using Flight__n_Bite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.ViewModels
{
    public class PersonnelMessagePageViewModel
    {
        HttpService httpService = HttpService.instance;
        public ObservableCollection<PersonnelMessage> Messages { get; set; }

        public PersonnelMessagePageViewModel()
        {
            Messages = new ObservableCollection<PersonnelMessage>();
        }

        private async void LoadMessages()
        {
            var json = await httpService.GetStringAsync(new Uri("http://localhost:49527/api/personnel/getMessages"));
            List<PersonnelMessage> list = JsonConvert.DeserializeObject<List<PersonnelMessage>>(json);
            foreach(var m in list)
            {
                Messages.Add(m);
            }
        }
    }
}
