using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace AP.Payment
{
    [DependsOn(
        typeof(PaymentApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class PaymentHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Payment";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(PaymentApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
