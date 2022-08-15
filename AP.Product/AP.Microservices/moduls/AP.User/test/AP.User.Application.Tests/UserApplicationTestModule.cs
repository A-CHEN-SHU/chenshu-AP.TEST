using Volo.Abp.Modularity;

namespace AP.User
{
    [DependsOn(
        typeof(UserApplicationModule),
        typeof(UserDomainTestModule)
        )]
    public class UserApplicationTestModule : AbpModule
    {

    }
}
