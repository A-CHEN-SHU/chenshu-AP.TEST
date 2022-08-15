using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace AP.Payment.MongoDB
{
    public class PaymentMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public PaymentMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}