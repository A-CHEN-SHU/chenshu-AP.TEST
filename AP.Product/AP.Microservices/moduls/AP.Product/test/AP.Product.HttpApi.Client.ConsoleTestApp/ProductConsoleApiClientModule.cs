using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AP.Product
{
    [DependsOn(
        typeof(ProductHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ProductConsoleApiClientModule : AbpModule
    {
        
    }
}
