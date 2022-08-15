using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AP.User.MongoDB
{
    [ConnectionStringName(UserDbProperties.ConnectionStringName)]
    public class UserMongoDbContext : AbpMongoDbContext, IUserMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUser();
        }
    }
}