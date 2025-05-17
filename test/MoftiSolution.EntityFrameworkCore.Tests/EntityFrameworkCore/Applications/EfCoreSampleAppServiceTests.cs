using MoftiSolution.Samples;
using Xunit;

namespace MoftiSolution.EntityFrameworkCore.Applications;

[Collection(MoftiSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MoftiSolutionEntityFrameworkCoreTestModule>
{

}
