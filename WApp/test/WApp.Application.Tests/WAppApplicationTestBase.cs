using Volo.Abp.Modularity;

namespace WApp;

public abstract class WAppApplicationTestBase<TStartupModule> : WAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
