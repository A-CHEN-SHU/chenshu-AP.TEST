using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AP.Order.Orders
{
    /// <summary>
    /// 订单仓储
    /// 1、做定制化
    /// </summary>
    public interface IOrderRepository : IRepository<Orders, Guid>
    {
    }
}
