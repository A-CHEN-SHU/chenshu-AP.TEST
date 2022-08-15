using AP.User.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AP.User
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UserEntityFrameworkCoreTestModule)
        )]
    public class UserDomainTestModule : AbpModule
    {
        
    }
}
