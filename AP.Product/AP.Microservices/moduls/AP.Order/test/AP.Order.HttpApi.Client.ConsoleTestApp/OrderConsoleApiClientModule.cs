using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AP.Order
{
    [DependsOn(
        typeof(OrderHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrderConsoleApiClientModule : AbpModule
    {
        
    }
}
