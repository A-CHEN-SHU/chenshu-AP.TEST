using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace AP.Product.Products
{
    /// <summary>
    /// 创建商品Dto
    /// 
    /// </summary>
    public class CreateProductDto /*: IValidatableObject*/
    {
        public string ProductUrl { set; get; }         // 商品主图
        /*[Required]
        [StringLength(10)]*/
        //[ProductName]
        //[Range(3, 10)]
        // 规则3：商品名称长度不能大于10
        // 规则4：商品名称不能有数字
        public string ProductTitle { set; get; }       //商品标题
        public string ProductDescription { set; get; }     // 图文描述
        public decimal ProductVirtualprice { set; get; } //商品虚拟价格
        public decimal ProductPrice { set; get; }       //价格

        public ProductImageCreateDto[] ProductImages { set; get; } // 商品图片集合
    }

    public class ProductImageCreateDto
    {
        public string ImageUrl { set; get; } // 图片url
        public string ImageStatus { set; get; } // 图片状态
    } 
}