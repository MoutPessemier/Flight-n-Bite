using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight__n_Bite.Models
{
    public class Movie
    {
        #region Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string PosterUri { get; set; }
        #endregion

        public Movie()
        {

        }
    }
}
