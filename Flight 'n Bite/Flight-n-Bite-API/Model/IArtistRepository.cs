namespace Flight_n_Bite_API.Model
{
    public interface IArtistRepository
    {
        void Add(Artist artist);
        void SaveChanges();
    }
}
