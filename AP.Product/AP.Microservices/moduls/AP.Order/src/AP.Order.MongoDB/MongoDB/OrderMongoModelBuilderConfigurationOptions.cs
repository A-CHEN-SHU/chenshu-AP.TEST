using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace AP.Order.MongoDB
{
    public class OrderMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OrderMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}