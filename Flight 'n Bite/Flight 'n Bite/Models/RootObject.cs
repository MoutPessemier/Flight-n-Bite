using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class RootObject
    {
        [JsonProperty("data")]
        public Data[] Datas { get; set; }
    }
    public class Data
    {
        [JsonProperty("coordinates")]
        public Coordinates[] Coordinates { get; set; }
    }
    public class Coordinates
    {
        [JsonProperty("dates")]
        public ObservableCollection<Day> Dates { get; set; }
    }

}
