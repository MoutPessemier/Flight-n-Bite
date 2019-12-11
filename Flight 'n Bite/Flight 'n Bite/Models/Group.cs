using System.Collections.Generic;

namespace Flight__n_Bite.Models
{
    public class Group
    {
        public int Id { get; set; }
        public List<Passenger> Companions { get; set; }
        public List<Message> Chat { get; set; }
    }
}
