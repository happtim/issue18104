using Volo.Abp.Modularity;

namespace issue18104;

[DependsOn(
    typeof(issue18104ApplicationModule),
    typeof(issue18104DomainTestModule)
    )]
public class issue18104ApplicationTestModule : AbpModule
{

}
