using Volo.Abp.Settings;

namespace MoftiSolution.Settings;

public class MoftiSolutionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MoftiSolutionSettings.MySetting1));
    }
}
