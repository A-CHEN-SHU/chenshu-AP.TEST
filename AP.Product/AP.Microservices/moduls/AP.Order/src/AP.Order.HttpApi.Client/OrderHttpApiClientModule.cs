using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace AP.Order
{
    [DependsOn(
        typeof(OrderApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OrderHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Order";//微服务通信

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
