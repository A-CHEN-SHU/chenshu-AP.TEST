using Volo.Abp.Modularity;

namespace AP.Order
{
    [DependsOn(
        typeof(OrderApplicationModule),
        typeof(OrderDomainTestModule)
        )]
    public class OrderApplicationTestModule : AbpModule
    {

    }
}
