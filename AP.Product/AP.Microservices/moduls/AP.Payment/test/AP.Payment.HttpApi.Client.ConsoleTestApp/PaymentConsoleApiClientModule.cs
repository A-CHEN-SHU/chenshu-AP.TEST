using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AP.Payment
{
    [DependsOn(
        typeof(PaymentHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PaymentConsoleApiClientModule : AbpModule
    {
        
    }
}
