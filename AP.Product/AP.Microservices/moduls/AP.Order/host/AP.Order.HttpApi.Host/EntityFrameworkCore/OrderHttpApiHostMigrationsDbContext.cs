using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AP.Order.EntityFrameworkCore
{
    public class OrderHttpApiHostMigrationsDbContext : AbpDbContext<OrderHttpApiHostMigrationsDbContext>
    {
        public OrderHttpApiHostMigrationsDbContext(DbContextOptions<OrderHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrder();
        }
    }
}
