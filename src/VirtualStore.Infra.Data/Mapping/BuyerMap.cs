using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Infra.Data.Mapping
{
    public class BuyerMap : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.ToTable("Buyer");
            builder.Property(b => b.Name).HasMaxLength(30).IsRequired();
            builder.Property(b => b.Surname).HasMaxLength(40).IsRequired();
            builder.Property(b => b.AddressId).IsRequired();
            builder.Property(b => b.Phone).HasMaxLength(14);
            builder.Property(b => b.Document).HasMaxLength(30);
            builder.Property(b => b.Gender).HasMaxLength(1);
            builder.Property(b => b.Email).HasMaxLength(50);
        }
    }
}
