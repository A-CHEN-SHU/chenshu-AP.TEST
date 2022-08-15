using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AP.Order.Orders
{
    /// <summary>
    /// 订单服务实现
    /// </summary>
    //[RemoteService(IsEnabled = false)]
    public class OrderAppService : CrudAppService<
                                            Orders,
                                            OrderDto,
                                            Guid,
                                            PagedAndSortedResultRequestDto,
                                            CreateOrderDto,
                                            UpdateOrderDto>, IOrderAppService
    {
        public IOrderRepository _OrderRepository;

        public OrderAppService(IOrderRepository repository)
            : base(repository)
        {
            this._OrderRepository = repository;
        }
        //public async Task<string> GetTony(Guid guid)
        //{
        //    Orders orders = await _OrderRepository.GetAsync(guid);
        //    Console.WriteLine("wwwwwwwwwwwwww");
        //    return "Tony";

        //}

        /* public async Task<OrderDto> CreateAsync(CreateOrderDto input)
         {
             // 1、创建订单
             //Orders order = new Orders(GuidGenerator.Create());
             // order = ObjectMapper.Map<CreateOrderDto,Orders>(input,order);
             // 1、获取用户信息
            // Claim[] claims = CurrentUser.GetAllClaims();
            // order.UserId = CurrentUser.Id.Value;
             // 2、保存订单
            // await _OrderRepository.InsertAsync(order);

             // 3、扣减商品库存
             // 1、先查询商品
             *//*foreach (var orderItemDto in input.OrderItems)
             {
                 Product product = await _productAbpRepository.GetAsync(orderItemDto.ProductId);
                 product.ProductStock = product.ProductStock - input.ProductCount;
                 await _productAbpRepository.UpdateAsync(product);
             }

             await CurrentUnitOfWork.SaveChangesAsync();*//*

             // 3.1 发送邮件
             *//*string flag = FeatureChecker.GetOrNullAsync(EBusinessFeatures.Orders.IsEmail).Result;
             if (flag.Equals("true"))
             {
                 Console.WriteLine("发送邮件");
             }

             // 3.2 发送短信
             string IsSmsflag = FeatureChecker.GetOrNullAsync(EBusinessFeatures.Orders.IsSms).Result;
             if (IsSmsflag.Equals("true"))
             {
                 Console.WriteLine("发送短信");
             }*//*

             // 权限，特征，设置。操作一模一样。本质：都是字符串。
             // 前提(场景)不一样。
             // 权限：用户 功能多少
             // 特征：多租户 。功能的多少。多租户功能多少
             // 设置：系统配置。功能的种类（选择）。多少不变，种类改变

             // 特征：默认是根据多租户来决定多少功能？
             // 扩展：根据用户来决定多少功能

             // _emailSender.SendAsync("网站","QQ","订单创建成功");

             // 4、返回订单
             return null;
         }*/


    }
}
