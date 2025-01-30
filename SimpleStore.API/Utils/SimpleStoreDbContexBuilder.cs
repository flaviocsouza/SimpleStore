using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SimpleStore.Infra.DbConfiguration;

namespace SimpleStore.API.Utils;

public class SimpleStoreDbContexBuilder : IDesignTimeDbContextFactory<SimpleStoreDbContext>
{
    public SimpleStoreDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        var builder = new DbContextOptionsBuilder<SimpleStoreDbContext>();
        builder.UseSqlServer(configuration.GetConnectionString("SimpleStoreConnectionString"));

        return new SimpleStoreDbContext(builder.Options);
    }
}
