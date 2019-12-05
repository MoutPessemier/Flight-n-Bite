using System;
using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public class Personnel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<PersonnelMessage> Messages { get; set; }

        public Personnel()
        {
            Messages = new List<PersonnelMessage>();
        }

        internal void addMessage(PersonnelMessage message)
        {
            Messages.Add(message);
        }
    }
}
