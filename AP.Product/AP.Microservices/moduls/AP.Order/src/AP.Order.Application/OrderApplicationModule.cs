﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace AP.Order
{
    [DependsOn(
        typeof(OrderDomainModule),
        typeof(OrderApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class OrderApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<OrderApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<OrderApplicationModule>(validate: false); // 设置字段不匹配校验
            });
        }
    }
}
