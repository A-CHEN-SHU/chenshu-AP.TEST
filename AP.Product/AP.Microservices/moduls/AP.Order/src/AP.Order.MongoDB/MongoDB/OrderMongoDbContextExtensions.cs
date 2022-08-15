using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AP.Order.MongoDB
{
    public static class OrderMongoDbContextExtensions
    {
        public static void ConfigureOrder(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrderMongoModelBuilderConfigurationOptions(
                OrderDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}