using issue18104.Localization;
using Volo.Abp.AspNetCore.Components;

namespace issue18104.Blazor;

public abstract class issue18104ComponentBase : AbpComponentBase
{
    protected issue18104ComponentBase()
    {
        LocalizationResource = typeof(issue18104Resource);
    }
}
