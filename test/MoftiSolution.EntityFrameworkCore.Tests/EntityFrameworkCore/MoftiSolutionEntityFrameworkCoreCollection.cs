using Xunit;

namespace MoftiSolution.EntityFrameworkCore;

[CollectionDefinition(MoftiSolutionTestConsts.CollectionDefinitionName)]
public class MoftiSolutionEntityFrameworkCoreCollection : ICollectionFixture<MoftiSolutionEntityFrameworkCoreFixture>
{

}
