using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SignalRTieredDemo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SignalRTieredDemoDbContextFactory : IDesignTimeDbContextFactory<SignalRTieredDemoDbContext>
{
    public SignalRTieredDemoDbContext CreateDbContext(string[] args)
    {
        SignalRTieredDemoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SignalRTieredDemoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SignalRTieredDemoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SignalRTieredDemo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
