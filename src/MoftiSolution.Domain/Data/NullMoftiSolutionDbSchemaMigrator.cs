using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MoftiSolution.Data;

/* This is used if database provider does't define
 * IMoftiSolutionDbSchemaMigrator implementation.
 */
public class NullMoftiSolutionDbSchemaMigrator : IMoftiSolutionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
