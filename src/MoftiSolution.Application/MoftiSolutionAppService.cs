using MoftiSolution.Localization;
using Volo.Abp.Application.Services;

namespace MoftiSolution;

/* Inherit your application services from this class.
 */
public abstract class MoftiSolutionAppService : ApplicationService
{
    protected MoftiSolutionAppService()
    {
        LocalizationResource = typeof(MoftiSolutionResource);
    }
}
