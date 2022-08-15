using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace AP.User.MongoDB
{
    public class UserMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UserMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}