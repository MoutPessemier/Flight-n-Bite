namespace Flight_n_Bite_API.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string body { get; set; }
        public Passenger Passenger { get; set; }
    }
}
