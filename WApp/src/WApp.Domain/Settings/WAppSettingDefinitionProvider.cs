using Volo.Abp.Settings;

namespace WApp.Settings;

public class WAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WAppSettings.MySetting1));
    }
}
