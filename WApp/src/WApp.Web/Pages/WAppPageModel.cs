using WApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class WAppPageModel : AbpPageModel
{
    protected WAppPageModel()
    {
        LocalizationResourceType = typeof(WAppResource);
    }
}
