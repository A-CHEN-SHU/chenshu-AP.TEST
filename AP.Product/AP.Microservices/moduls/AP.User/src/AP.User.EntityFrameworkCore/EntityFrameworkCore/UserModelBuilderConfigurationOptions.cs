using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AP.User.EntityFrameworkCore
{
    public class UserModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UserModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}