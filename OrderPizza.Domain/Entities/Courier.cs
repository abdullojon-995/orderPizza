namespace OrderPizza.Domain.Entities
{
    public class Courier : User
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
