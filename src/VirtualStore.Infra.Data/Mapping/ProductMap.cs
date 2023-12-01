using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualStore.Domain.Entities;

namespace VirtualStore.Infra.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(p => p.Name).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(120).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(p => p.PictureUri).HasMaxLength(120).IsRequired();
            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.BrandId).IsRequired();
        }
    }
}
