﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace AP.Order.Orders
{
    /// <summary>
    /// 订单模型
    /// </summary>
    public class Orders : AggregateRoot<Guid>
    {
        //[Key]
        //  public int Id { set; get; } // 主键
        public string OrderType { set; get; } // 订单类型
                                              // public string OrderFlag { set; get; } // 订单标志
        public Guid UserId { set; get; } // 用户Id
        public string OrderSn { set; get; }// 订单号
        public string OrderTotalPrice { set; get; } // 订单总价
        public DateTime Createtime { set; get; } // 创建时间
        public DateTime Updatetime { set; get; } // 更新时间
        public DateTime Paytime { set; get; }// 支付时间
        public DateTime Sendtime { set; get; }// 发货时间
        public DateTime Successtime { set; get; }// 订单完成时间
        public int OrderStatus { set; get; } // 订单状态
        public string OrderName { set; get; } // 订单名称
        public string OrderTel { set; get; } // 订单电话
        public string OrderAddress { set; get; } // 订单地址
        public string OrderRemark { set; get; }// 订单备注

        // 订单项
        public ICollection<OrderItem> OrderItems { set; get; }


        public Orders()
        {
            OrderItems = new Collection<OrderItem>();
        }

        public Orders(Guid id) : base(id)
        {
            OrderItems = new Collection<OrderItem>();
        }

        /// <summary>
        /// 添加商品图片
        /// </summary>
        public void AddOrderItem(Guid itemId, string OrderSn, string ProductName, decimal ItemPrice)
        {
            // 1、创建一个商品图片
            OrderItem productImage = new OrderItem(itemId);
            productImage.OrderSn = OrderSn;
            productImage.ProductName = ProductName;
            productImage.ItemPrice = ItemPrice;

            // 2、添加到集合中
            OrderItems.Add(productImage);
        }
    }
}