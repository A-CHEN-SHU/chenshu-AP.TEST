using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AP.Payment.EntityFrameworkCore
{
    public class PaymentModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public PaymentModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}