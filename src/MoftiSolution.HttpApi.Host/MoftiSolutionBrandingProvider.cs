using Microsoft.Extensions.Localization;
using MoftiSolution.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MoftiSolution;

[Dependency(ReplaceServices = true)]
public class MoftiSolutionBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MoftiSolutionResource> _localizer;

    public MoftiSolutionBrandingProvider(IStringLocalizer<MoftiSolutionResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
