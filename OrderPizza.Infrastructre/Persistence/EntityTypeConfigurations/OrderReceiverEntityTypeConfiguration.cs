using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderPizza.Domain.Entities;

namespace OrderPizza.Infrastructre.Persistence.EntityTypeConfigurations
{
    public class OrderReceiverEntityTypeConfiguration : IEntityTypeConfiguration<OrderReceiver>
    {
        public void Configure(EntityTypeBuilder<OrderReceiver> builder)
        {
            builder.ToTable("OrderReceivers");

            builder.HasKey(x => x.Id);
        }
    }
}
