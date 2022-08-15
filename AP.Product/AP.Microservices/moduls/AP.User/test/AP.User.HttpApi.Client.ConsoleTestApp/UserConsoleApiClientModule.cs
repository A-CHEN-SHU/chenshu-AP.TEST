using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AP.User
{
    [DependsOn(
        typeof(UserHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UserConsoleApiClientModule : AbpModule
    {
        
    }
}
