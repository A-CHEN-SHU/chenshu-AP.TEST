using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AP.Product.EntityFrameworkCore
{
    public class ProductHttpApiHostMigrationsDbContext : AbpDbContext<ProductHttpApiHostMigrationsDbContext>
    {
        public ProductHttpApiHostMigrationsDbContext(DbContextOptions<ProductHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureProduct();
        }
    }
}
