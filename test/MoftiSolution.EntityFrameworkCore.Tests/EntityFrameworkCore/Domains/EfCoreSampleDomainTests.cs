using MoftiSolution.Samples;
using Xunit;

namespace MoftiSolution.EntityFrameworkCore.Domains;

[Collection(MoftiSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MoftiSolutionEntityFrameworkCoreTestModule>
{

}
