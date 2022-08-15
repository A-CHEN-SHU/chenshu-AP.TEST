using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AP.Payment
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(PaymentDomainSharedModule)
    )]
    public class PaymentDomainModule : AbpModule
    {

    }
}
