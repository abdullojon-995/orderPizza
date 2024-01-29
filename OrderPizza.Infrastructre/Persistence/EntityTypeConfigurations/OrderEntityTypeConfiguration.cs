using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderPizza.Domain.Entities;

namespace OrderPizza.Infrastructre.Persistence.EntityTypeConfigurations
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                   .WithOne(x => x.Order)
                   .HasForeignKey<Order>(x => x.UserId);
        }
    }
}
