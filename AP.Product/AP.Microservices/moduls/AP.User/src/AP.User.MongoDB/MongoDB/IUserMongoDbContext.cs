using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AP.User.MongoDB
{
    [ConnectionStringName(UserDbProperties.ConnectionStringName)]
    public interface IUserMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
