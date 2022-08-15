using AP.Order.Orders;
using AutoMapper;

namespace AP.Order
{
    public class OrderApplicationAutoMapperProfile : Profile
    {
        public OrderApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Orders.Orders, OrderDto>();
            CreateMap<OrderItem, OrderItemDto>();

            CreateMap<CreateOrderDto, Orders.Orders>();
            CreateMap<CreateOrderItemDto, OrderItem>();
        }
    }
}