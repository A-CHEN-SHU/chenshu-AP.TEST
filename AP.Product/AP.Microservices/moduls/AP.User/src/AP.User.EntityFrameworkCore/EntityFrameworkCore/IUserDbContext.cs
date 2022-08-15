using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AP.User.EntityFrameworkCore
{
    [ConnectionStringName(UserDbProperties.ConnectionStringName)]
    public interface IUserDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}