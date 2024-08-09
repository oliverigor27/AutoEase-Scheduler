using System;
using Autoease.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class GarageEntityConfiguration : IEntityTypeConfiguration<GarageEntity>
{
    public void Configure(EntityTypeBuilder<GarageEntity> builder)
    {
        builder.HasKey(garage => garage.Id)
            .HasName("id");
        
        builder.Property(garage => garage.GarageRegister)
            .HasColumnName("garage_register")
            .IsRequired();

        builder.Property(garage => garage.GarageName)
            .HasColumnName("garage_name")
            .HasMaxLength(160)
            .IsRequired();

        builder.Property(garage => garage.Email)
            .HasColumnName("email")
            .IsRequired();
        
        builder.Property(garage => garage.Password)
            .HasColumnName("password")
            .IsRequired();

        builder.Property(garage => garage.Phone)
            .HasColumnName("phone")
            .IsRequired();

        builder.Property(garage => garage.OpenTime)
            .HasColumnName("open_time")
            .IsRequired();

        builder.Property(garage => garage.CloseTime)
            .HasColumnName("close_time")
            .IsRequired();
    }
}
