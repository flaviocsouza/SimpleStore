using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.EntityConfigurations;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SalesItems");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CreatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.UpdatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.DeletedAt)
            .HasColumnType("DateTime");


        builder.Property(p => p.ProductId)
            .HasColumnType("Varchar(36)")
            .IsRequired();

        builder.Property(p => p.SaleId)
            .HasColumnType("Varchar(36)")
            .IsRequired();

        builder.Property(p => p.Quantity)
            .HasColumnType("Integer")
            .IsRequired();

        builder.HasOne(p => p.Sale)
            .WithMany(s => s.SaleItems)
            .HasForeignKey(s => s.SaleId);

        builder.HasOne(p => p.Product);
    }
}
