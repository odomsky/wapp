using Volo.Abp.Modularity;

namespace WApp;

[DependsOn(
    typeof(WAppDomainModule),
    typeof(WAppTestBaseModule)
)]
public class WAppDomainTestModule : AbpModule
{

}
