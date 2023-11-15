using System.Threading.Tasks;

namespace issue18104.Data;

public interface Iissue18104DbSchemaMigrator
{
    Task MigrateAsync();
}
