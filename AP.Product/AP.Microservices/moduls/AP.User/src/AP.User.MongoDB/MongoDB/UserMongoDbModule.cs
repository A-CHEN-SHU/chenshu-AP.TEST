using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace AP.User.MongoDB
{
    [DependsOn(
        typeof(UserDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class UserMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<UserMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
