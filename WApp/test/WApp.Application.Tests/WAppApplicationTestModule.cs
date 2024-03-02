using Volo.Abp.Modularity;

namespace WApp;

[DependsOn(
    typeof(WAppApplicationModule),
    typeof(WAppDomainTestModule)
)]
public class WAppApplicationTestModule : AbpModule
{

}
