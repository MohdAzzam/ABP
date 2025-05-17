using System.Threading.Tasks;

namespace MoftiSolution.Data;

public interface IMoftiSolutionDbSchemaMigrator
{
    Task MigrateAsync();
}
