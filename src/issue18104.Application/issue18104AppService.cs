using System;
using System.Collections.Generic;
using System.Text;
using issue18104.Localization;
using Volo.Abp.Application.Services;

namespace issue18104;

/* Inherit your application services from this class.
 */
public abstract class issue18104AppService : ApplicationService
{
    protected issue18104AppService()
    {
        LocalizationResource = typeof(issue18104Resource);
    }
}
