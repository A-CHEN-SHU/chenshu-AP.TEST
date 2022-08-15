using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AP.Product.EntityFrameworkCore
{
    [ConnectionStringName(ProductDbProperties.ConnectionStringName)]
    public class ProductDbContext : AbpDbContext<ProductDbContext>, IProductDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Products.Products> Products { get; set; }// 配置商品(以领域为单位)

        public ProductDbContext(DbContextOptions<ProductDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureProduct();
        }
    }
}