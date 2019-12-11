namespace Flight_n_Bite_API.Model
{
    public class ArtistMovie
    {
        #region Properties
        public int MovieId { get; set; }
        public int ArtistId { get; set; }

        public Movie Movie { get; set; }
        public Artist Artist { get; set; }
        #endregion
    }
}
