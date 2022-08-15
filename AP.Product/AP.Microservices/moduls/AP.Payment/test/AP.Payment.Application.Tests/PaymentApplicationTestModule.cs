using Volo.Abp.Modularity;

namespace AP.Payment
{
    [DependsOn(
        typeof(PaymentApplicationModule),
        typeof(PaymentDomainTestModule)
        )]
    public class PaymentApplicationTestModule : AbpModule
    {

    }
}
