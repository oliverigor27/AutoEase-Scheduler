using Autoease.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class ServicesEntityConfiguration : IEntityTypeConfiguration<Services>
{
    public void Configure(EntityTypeBuilder<Services> builder)
    {
        builder.HasKey(s => s.Id)
            .HasName("service_id");
        
        builder.Property(s => s.Description)
            .HasColumnName("service_description")
            .IsRequired();

        builder.Property(s => s.Price)
            .HasColumnName("service_price")
            .IsRequired();

        builder.Property(s => s.Created_At)
            .HasColumnName("created_at")
            .IsRequired();
    }
}
