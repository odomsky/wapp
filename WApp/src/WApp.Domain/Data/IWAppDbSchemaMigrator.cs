using System.Threading.Tasks;

namespace WApp.Data;

public interface IWAppDbSchemaMigrator
{
    Task MigrateAsync();
}
