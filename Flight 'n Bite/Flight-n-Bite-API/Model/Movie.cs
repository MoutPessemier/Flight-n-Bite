using System;
using System.Collections.Generic;

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
        public IList<Artist> Cast { get; set; }
        public string Director { get; set; }
        #endregion

        public Movie()
        {
            Cast = new List<Artist>();
        }

        public void AddActor(Artist artist)
        {
            Cast.Add(artist);
        }
    }
}
