using Ecommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ecommerce.Public;

[DependsOn(
    typeof(EcommerceEntityFrameworkCoreTestModule)
    )]
public class PublicDomainTestModule : AbpModule
{

}
