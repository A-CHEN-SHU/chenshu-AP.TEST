using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AP.Order.EntityFrameworkCore
{
    public class OrderModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OrderModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}