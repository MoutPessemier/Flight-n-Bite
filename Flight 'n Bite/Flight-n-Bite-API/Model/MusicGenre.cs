using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public class MusicGenre
    {
        #region Properties
        public int MusicId { get; set; }
        public int GenreId { get; set; }

        public Music Song { get; set; }
        public Genre Genre { get; set; }
        #endregion
    }
}
