using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AP.Order.Orders
{
    /// <summary>
    /// 订单应用服务接口
    /// </summary>
    public interface IOrderAppService : ICrudAppService<
                                            OrderDto,
                                            Guid,
                                            PagedAndSortedResultRequestDto,
                                            CreateOrderDto,
                                            UpdateOrderDto>
    {
        //public Task<string> GetTony(Guid guid);
    }
}
