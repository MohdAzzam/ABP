using Volo.Abp.Modularity;

namespace MoftiSolution;

public abstract class MoftiSolutionApplicationTestBase<TStartupModule> : MoftiSolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
