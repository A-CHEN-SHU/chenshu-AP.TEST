using AP.Order.EntityFrameworkCore;
using AP.Order.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Linq;

namespace AP.Order.Orders
{
    /// <summary>
    /// 商品仓储实现
    /// </summary>
    [Dependency(ServiceLifetime.Transient)]
    public class OrderRepository : EfCoreRepository<OrderDbContext, Orders, Guid>, IOrderRepository
    {
        public OrderRepository(
            IDbContextProvider<OrderDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public override async Task<Orders> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            DbSet<Orders> orders = await GetDbSetAsync();
            return orders.Include(o => o.OrderItems).Where(o => o.Id == id).FirstOrDefault();
        }
    }
}
