using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AP.User.MongoDB
{
    public static class UserMongoDbContextExtensions
    {
        public static void ConfigureUser(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UserMongoModelBuilderConfigurationOptions(
                UserDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}