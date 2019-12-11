using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IMusicRepository
    {
        IEnumerable<Music> GetSongs();
        Music GetSong(int id);
        void Add(Music music);
        void SaveChagnes();
    }
}
