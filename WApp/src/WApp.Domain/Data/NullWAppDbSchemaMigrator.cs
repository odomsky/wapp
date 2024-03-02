using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WApp.Data;

/* This is used if database provider does't define
 * IWAppDbSchemaMigrator implementation.
 */
public class NullWAppDbSchemaMigrator : IWAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
