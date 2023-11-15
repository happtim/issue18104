using issue18104.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace issue18104;

[DependsOn(
    typeof(issue18104EntityFrameworkCoreTestModule)
    )]
public class issue18104DomainTestModule : AbpModule
{

}
