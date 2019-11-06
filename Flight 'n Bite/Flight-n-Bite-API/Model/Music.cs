using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class Music
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public string Album { get; set; }
        public string CoverUri { get; set; }
        public IList<Artist> CoArtists { get; set; }
        #endregion

        public Music()
        {
            CoArtists = new List<Artist>();
        }

        public void AddArtist(Artist artist)
        {
            CoArtists.Add(artist);
        }
    }
}
