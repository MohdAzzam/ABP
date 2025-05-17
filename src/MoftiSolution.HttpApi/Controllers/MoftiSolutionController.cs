using MoftiSolution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MoftiSolution.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MoftiSolutionController : AbpControllerBase
{
    protected MoftiSolutionController()
    {
        LocalizationResource = typeof(MoftiSolutionResource);
    }
}
