using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace issue18104.Blazor;

[Dependency(ReplaceServices = true)]
public class issue18104BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "issue18104";
}
