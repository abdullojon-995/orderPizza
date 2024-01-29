namespace OrderPizza.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public Courier Courier { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
