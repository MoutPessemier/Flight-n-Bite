using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IArtistRepository
    {
        void Add(Artist artist);
        void SaveChanges();
    }
}
