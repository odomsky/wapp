using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WApp.Web;

[Dependency(ReplaceServices = true)]
public class WAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WApp";
}
