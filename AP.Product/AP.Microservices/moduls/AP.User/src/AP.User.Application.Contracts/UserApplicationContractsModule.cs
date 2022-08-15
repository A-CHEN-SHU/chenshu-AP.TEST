using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AP.User
{
    [DependsOn(
        typeof(UserDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class UserApplicationContractsModule : AbpModule
    {

    }
}
