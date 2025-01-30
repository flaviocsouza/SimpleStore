using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SimpleStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStore.Infra.DbConfiguration;

public class SimpleStoreDbContext : DbContext
{
    public SimpleStoreDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Customer> Customers {get; set; }
    public DbSet<Product> Products {get; set; }
    public DbSet<Supplier> Suppliers {get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SalesItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SimpleStoreDbContext).Assembly);

        foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

        base.OnModelCreating(modelBuilder);
    }
}
