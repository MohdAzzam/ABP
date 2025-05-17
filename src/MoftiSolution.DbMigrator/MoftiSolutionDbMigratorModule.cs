using MoftiSolution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MoftiSolution.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MoftiSolutionEntityFrameworkCoreModule),
    typeof(MoftiSolutionApplicationContractsModule)
)]
public class MoftiSolutionDbMigratorModule : AbpModule
{
}
