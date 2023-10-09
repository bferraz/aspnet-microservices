using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(o => o.TotalPrice)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(o => o.FirstName)
                .IsRequired()
                .HasMaxLength(50);            
        }
    }
}
