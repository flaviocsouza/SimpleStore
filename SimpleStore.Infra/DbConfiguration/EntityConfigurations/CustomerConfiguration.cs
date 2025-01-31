using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStore.Infra.DbConfiguration.EntityConfigurations;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CreatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.UpdatedAt)
            .HasColumnType("DateTime")
            .IsRequired();

        builder.Property(p => p.DeletedAt)
            .HasColumnType("DateTime");

        builder.Property(p => p.FullName)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.Email)
            .HasColumnType("Varchar(80)")
            .IsRequired();

        builder.Property(p => p.PhoneNumber)
            .HasColumnType("Varchar(15)")
            .IsRequired();

        builder.Property(p => p.Address)
            .HasColumnType("Varchar(120)")
            .IsRequired();

    }
}
