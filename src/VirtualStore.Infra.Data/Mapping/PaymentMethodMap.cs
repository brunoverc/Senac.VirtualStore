using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Infra.Data.Mapping
{
    public class PaymentMethodMap : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");
            builder.Property(pm => pm.CardBrand).IsRequired().HasMaxLength(10);
            builder.Property(pm => pm.CardId).IsRequired();
            builder.Property(pm => pm.Last4).IsRequired().HasMaxLength(4);

            builder.HasOne(pm => pm.Buyer)
                .WithMany(b => b.PaymentMethods)
                .HasForeignKey(pm => pm.BuyerId)
                .HasConstraintName("fk_PaymentMethod_buyer")
                .IsRequired();
        }
    }
}
