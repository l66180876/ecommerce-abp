﻿using System;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace Ecommerce.EntityFrameworkCore;

public class EntityFrameworkCoreEcommerceDbSchemaMigrator
    : IEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TeduEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
