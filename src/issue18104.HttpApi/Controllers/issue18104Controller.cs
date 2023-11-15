using issue18104.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace issue18104.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class issue18104Controller : AbpControllerBase
{
    protected issue18104Controller()
    {
        LocalizationResource = typeof(issue18104Resource);
    }
}
