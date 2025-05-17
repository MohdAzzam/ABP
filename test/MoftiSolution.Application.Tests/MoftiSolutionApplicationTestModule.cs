using Volo.Abp.Modularity;

namespace MoftiSolution;

[DependsOn(
    typeof(MoftiSolutionApplicationModule),
    typeof(MoftiSolutionDomainTestModule)
)]
public class MoftiSolutionApplicationTestModule : AbpModule
{

}
