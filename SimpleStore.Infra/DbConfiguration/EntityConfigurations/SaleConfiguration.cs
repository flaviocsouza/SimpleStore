using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.EntityConfigurations;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CreatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.UpdatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.DeletedAt)
            .HasColumnType("DateTime");

        builder.Property(p => p.CustomerId)
            .HasColumnType("Varchar(36)")
            .IsRequired();

        builder.Property(p => p.SaleDate)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.HasMany(p => p.SaleItems)
            .WithOne(s => s.Sale)
            .HasForeignKey(s => s.SaleId);

        builder.HasOne(p => p.Customer)
            .WithMany(c => c.Sales)
            .HasForeignKey(p => p.CustomerId);
    }
}
