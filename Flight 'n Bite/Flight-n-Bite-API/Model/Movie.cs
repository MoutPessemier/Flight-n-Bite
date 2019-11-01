using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class Movie
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string PosterUri { get; set; }
        public IEnumerable<String> Cast { get; set; }
        public String Director { get; set; }
        #endregion
    }
}
