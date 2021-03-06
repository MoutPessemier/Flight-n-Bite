﻿using Newtonsoft.Json;
using System.Collections.Generic;

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
        public List<DateValue> Dates { get; set; }
    }
    public class DateValue
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
