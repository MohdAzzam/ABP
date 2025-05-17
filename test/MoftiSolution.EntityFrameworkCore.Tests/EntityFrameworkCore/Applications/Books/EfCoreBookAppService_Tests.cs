using MoftiSolution.Books;
using Xunit;

namespace MoftiSolution.EntityFrameworkCore.Applications.Books;

[Collection(MoftiSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<MoftiSolutionEntityFrameworkCoreTestModule>
{

}