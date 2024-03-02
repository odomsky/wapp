using WApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WAppController : AbpControllerBase
{
    protected WAppController()
    {
        LocalizationResource = typeof(WAppResource);
    }
}
