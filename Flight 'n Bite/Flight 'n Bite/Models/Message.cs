using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Flight__n_Bite.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public Passenger Passenger { get; set; }
        public HorizontalAlignment Alignment { get; set; }

        public Message()
        {
            Alignment = HorizontalAlignment.Left;
        }
    }
}
