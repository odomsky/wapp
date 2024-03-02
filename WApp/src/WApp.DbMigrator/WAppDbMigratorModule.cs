using WApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace WApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WAppEntityFrameworkCoreModule),
    typeof(WAppApplicationContractsModule)
    )]
public class WAppDbMigratorModule : AbpModule
{
}
