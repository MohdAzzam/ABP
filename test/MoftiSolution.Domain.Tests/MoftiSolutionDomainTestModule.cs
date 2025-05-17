using Volo.Abp.Modularity;

namespace MoftiSolution;

[DependsOn(
    typeof(MoftiSolutionDomainModule),
    typeof(MoftiSolutionTestBaseModule)
)]
public class MoftiSolutionDomainTestModule : AbpModule
{

}
