using Volo.Abp.Settings;

namespace issue18104.Settings;

public class issue18104SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(issue18104Settings.MySetting1));
    }
}
