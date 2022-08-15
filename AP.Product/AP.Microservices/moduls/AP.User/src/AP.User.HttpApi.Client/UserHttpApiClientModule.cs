using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace AP.User
{
    [DependsOn(
        typeof(UserApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UserHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "User";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UserApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
