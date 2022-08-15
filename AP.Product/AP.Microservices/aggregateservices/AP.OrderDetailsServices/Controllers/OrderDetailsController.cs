using AP.Order.Orders;
using AP.Product.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP.OrderDetailsServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly ILogger<OrderDetailsController> _logger;

        public IProductAppService _ProductAppService { set; get; }
        public IOrderAppService _OrderAppService { set; get; }

        public OrderDetailsController(ILogger<OrderDetailsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<OrderDto> Get(Guid OrderId)
        {
            // 1、查询订单
            OrderDto orderDto = await _OrderAppService.GetAsync(OrderId);

            // 2、查询商品
            OrderItemDto[] orderItemDtos = orderDto.OrderItems;
            foreach (var orderItem in orderItemDtos)
            {
                ProductDto productDto = await _ProductAppService.GetAsync(orderItem.ProductId);

                //3、设置商品名称
                orderItem.ProductName = productDto.ProductTitle;
            }
            // 2、查询商品
            return orderDto;
        }
    }
}
