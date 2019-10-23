using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    class Flight
    {
        #region Properties
        public int Id { get; set; }
        public string Number { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }

        #endregion
        public Flight()
        {

        }
    }
}
