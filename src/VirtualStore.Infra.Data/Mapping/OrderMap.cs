using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Infra.Data.Mapping
{

    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.Property(o => o.BuyerId).IsRequired();
            builder.Property(o => o.AddressId).IsRequired();
            builder.Property(o => o.TotalValue).HasPrecision(10, 2).IsRequired();
            builder.Property(o => o.Discount).HasPrecision(10, 2).HasDefaultValue(0);
        }
    }
}
