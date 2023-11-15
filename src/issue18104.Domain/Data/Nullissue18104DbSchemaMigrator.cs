using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace issue18104.Data;

/* This is used if database provider does't define
 * Iissue18104DbSchemaMigrator implementation.
 */
public class Nullissue18104DbSchemaMigrator : Iissue18104DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
