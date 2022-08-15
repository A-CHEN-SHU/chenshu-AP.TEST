using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AP.Order.EntityFrameworkCore
{
    [DependsOn(
        typeof(OrderDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class OrderEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OrderDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}