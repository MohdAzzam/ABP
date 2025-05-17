using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoftiSolution.Data;
using Volo.Abp.DependencyInjection;

namespace MoftiSolution.EntityFrameworkCore;

public class EntityFrameworkCoreMoftiSolutionDbSchemaMigrator
    : IMoftiSolutionDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMoftiSolutionDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MoftiSolutionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MoftiSolutionDbContext>()
            .Database
            .MigrateAsync();
    }
}
