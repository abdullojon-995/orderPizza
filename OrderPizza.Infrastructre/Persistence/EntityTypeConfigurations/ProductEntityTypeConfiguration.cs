using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderPizza.Domain.Entities;

namespace OrderPizza.Infrastructre.Persistence.EntityTypeConfigurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Order)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.OrderId);
        }
    }
}
