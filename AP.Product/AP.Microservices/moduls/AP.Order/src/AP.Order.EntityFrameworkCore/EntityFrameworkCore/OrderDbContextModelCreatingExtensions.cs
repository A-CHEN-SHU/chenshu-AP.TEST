using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AP.Order.EntityFrameworkCore
{
    public static class OrderDbContextModelCreatingExtensions
    {
        public static void ConfigureOrder(
            this ModelBuilder builder,
            Action<OrderModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrderModelBuilderConfigurationOptions(
                OrderDbProperties.DbTablePrefix,
                OrderDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:在这里配置所有实体。例子
            
            builder.Entity<Question>(b =>
            {
                //Configure table & schema name 配置表和模式名
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties 属性
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations 关系
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes 索引
                b.HasIndex(q => q.CreationTime);
            });
            */
            builder.Entity<Orders.Orders>(b =>
            {
                b.ConfigureByConvention();
                b.HasMany(u => u.OrderItems).WithOne().HasForeignKey(ur=>ur.OrderId);
            });
        }
    }
}