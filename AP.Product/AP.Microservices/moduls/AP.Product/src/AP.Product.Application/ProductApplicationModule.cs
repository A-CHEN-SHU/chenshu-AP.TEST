using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace AP.Product
{
    [DependsOn(
        typeof(ProductDomainModule),
        typeof(ProductApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ProductApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<ProductApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ProductApplicationModule>(validate: false); // 设置字段不匹配校验
            });
        }
    }
}
