using Volo.Abp.Modularity;

namespace WApp;

/* Inherit from this class for your domain layer tests. */
public abstract class WAppDomainTestBase<TStartupModule> : WAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
