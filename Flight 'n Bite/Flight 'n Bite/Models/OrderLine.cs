namespace Flight__n_Bite.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
