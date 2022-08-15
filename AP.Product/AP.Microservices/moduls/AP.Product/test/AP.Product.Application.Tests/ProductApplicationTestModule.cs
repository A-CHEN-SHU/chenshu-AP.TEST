using Volo.Abp.Modularity;

namespace AP.Product
{
    [DependsOn(
        typeof(ProductApplicationModule),
        typeof(ProductDomainTestModule)
        )]
    public class ProductApplicationTestModule : AbpModule
    {

    }
}
