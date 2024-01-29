using OrderPizza.Domain.Enums;

namespace OrderPizza.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
