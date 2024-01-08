using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Ecommerce.Data;

/* This is used if database provider does't define
 * ITeduEcommerceDbSchemaMigrator implementation.
 */
public class NullEcommerceDbSchemaMigrator : IEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
