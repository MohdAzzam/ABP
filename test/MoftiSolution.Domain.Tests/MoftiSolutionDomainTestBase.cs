using Volo.Abp.Modularity;

namespace MoftiSolution;

/* Inherit from this class for your domain layer tests. */
public abstract class MoftiSolutionDomainTestBase<TStartupModule> : MoftiSolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
