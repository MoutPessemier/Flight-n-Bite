using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    [JsonObject]
    public class Day
    {
        #region Properties
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("value")]
        public double Temperature { get; set; }
        #endregion

        public Day()
        {

        }
    }

}
