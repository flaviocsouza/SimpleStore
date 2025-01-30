using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.EntityConfigurations;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.ToTable("Suppliers");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CreatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.UpdatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.DeletedAt)
            .HasColumnType("DateTime");

        builder.Property(p => p.Name)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.ContactName)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.Phone)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.Email)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.Address)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.HasMany(p => p.Products)
            .WithMany(pr => pr.Suppliers)
            .UsingEntity<ProductSupplier>();
    }
}

public class ProductSupplierConfiguration : IEntityTypeConfiguration<ProductSupplier>
{
    public void Configure(EntityTypeBuilder<ProductSupplier> builder)
    {
        builder.ToTable("ProductsSuppliers");

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

        builder.Property(p => p.SupplierId)
            .HasColumnType("Varchar(36)")
            .IsRequired();


        builder.Property(p => p.Price)
            .HasColumnType("Decimal")
            .IsRequired();

        builder.HasOne(p => p.Supplier)
            .WithMany(s => s.ProductsSuppliers)
            .HasForeignKey(p => p.SupplierId);

        builder.HasOne(p => p.Product)
            .WithMany(s => s.ProductsSuppliers)
            .HasForeignKey(p => p.ProductId);
    }
}
