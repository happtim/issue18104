using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using issue18104.Data;
using Volo.Abp.DependencyInjection;

namespace issue18104.EntityFrameworkCore;

public class EntityFrameworkCoreissue18104DbSchemaMigrator
    : Iissue18104DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreissue18104DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the issue18104DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<issue18104DbContext>()
            .Database
            .MigrateAsync();
    }
}
