using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CreatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.UpdatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.DeletedAt)
            .HasColumnType("DateTime");

        builder.Property(p  => p.Name)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.Description)
            .HasColumnType("Varchar(120)")
            .IsRequired();

        builder.Property(p => p.Price)
            .HasColumnType("Decimal")
            .IsRequired();

        builder.Property(p => p.StockQuantity)
            .HasColumnType("Integer")
            .IsRequired();
    }
}
