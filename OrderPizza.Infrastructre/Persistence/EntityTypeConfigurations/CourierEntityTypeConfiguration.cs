using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderPizza.Domain.Entities;

namespace OrderPizza.Infrastructre.Persistence.EntityTypeConfigurations
{
    public class CourierEntityTypeConfiguration : IEntityTypeConfiguration<Courier>
    {
        public void Configure(EntityTypeBuilder<Courier> builder)
        {
            builder.ToTable("Couriers");

            builder.HasKey(e => e.Id);

            builder.HasOne(x => x.Order)
                   .WithOne(x => x.Courier)
                   .HasForeignKey<Courier>(x => x.OrderId);
        }
    }
}
