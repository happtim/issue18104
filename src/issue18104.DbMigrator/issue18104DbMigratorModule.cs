using issue18104.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace issue18104.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(issue18104EntityFrameworkCoreModule),
    typeof(issue18104ApplicationContractsModule)
    )]
public class issue18104DbMigratorModule : AbpModule
{

}
