namespace Flight_n_Bite_API.Model
{
    public class ArtistMusic
    {
        #region Properties
        public int SongId { get; set; }
        public int ArtistId { get; set; }

        public Music Song { get; set; }
        public Artist Artist { get; set; }
        #endregion
    }
}
