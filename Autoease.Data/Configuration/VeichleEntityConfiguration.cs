using Autoease.Domain.AggregateModel.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class VeichleEntityConfiguration : IEntityTypeConfiguration<Veichle>
{
    public void Configure(EntityTypeBuilder<Veichle> builder)
    {
        builder.HasKey(v => v.Id)
            .HasName("veichle_id");

        builder.Property(v => v.Model)
            .HasColumnName("veichle_model")
            .IsRequired();

        builder.Property(v => v.Color)
            .HasColumnName("veichle_color")
            .IsRequired();

        builder.Property(v => v.Plate)
            .HasColumnName("veichle_plate")
            .IsRequired();

        builder.Property(v => v.Year)
            .HasColumnName("veichle_year")
            .IsRequired();

        builder.Property(v => v.Created_At)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property<UserEntity>("Id")
            .HasColumnName("user_id")
            .IsRequired();
    }
}
