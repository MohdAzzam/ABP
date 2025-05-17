using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MoftiSolution.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MoftiSolutionDbContextFactory : IDesignTimeDbContextFactory<MoftiSolutionDbContext>
{
    public MoftiSolutionDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        MoftiSolutionEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MoftiSolutionDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new MoftiSolutionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MoftiSolution.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
