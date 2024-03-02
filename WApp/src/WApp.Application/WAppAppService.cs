using System;
using System.Collections.Generic;
using System.Text;
using WApp.Localization;
using Volo.Abp.Application.Services;

namespace WApp;

/* Inherit your application services from this class.
 */
public abstract class WAppAppService : ApplicationService
{
    protected WAppAppService()
    {
        LocalizationResource = typeof(WAppResource);
    }
}
