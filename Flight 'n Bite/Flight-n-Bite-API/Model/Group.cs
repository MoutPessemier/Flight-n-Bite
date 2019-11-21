using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class Group
    {
        public int Id { get; set; }
        public List<Passenger> Companions { get; set; }
        public List<Message> Chat { get; set; }


        public Group()
        {
            Companions = new List<Passenger>();
            Chat = new List<Message>();

        }

        public void JoinGroup(Passenger passenger)
        {
            Companions.Add(passenger);
        }

        public void SendMessage(Message message)
        {
            Chat.Add(message);
        }

    }
}
