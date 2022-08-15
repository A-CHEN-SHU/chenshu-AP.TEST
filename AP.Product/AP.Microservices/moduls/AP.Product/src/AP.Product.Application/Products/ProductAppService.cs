using AP.Product.Products;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AP.Product.Products
{
    /// <summary>
    /// 商品服务实现
    /// 1个前提 用户要登录
    /// 2个步骤 
    ///  1、定义权限
    ///  2、给接口授权
    ///   2.1 给用户授权
    /// 
    /// 鉴权操作：校验用户是否有相应权限("EBusiness.Products")
    ///
    /// 进一步操作
    /// 1、定义权限：
    ///    1、类描述对象
    ///    2、有提供者对象
    ///    3、有管理者对象
    /// 2、授权：
    ///     1、校验输入的权限字符串
    ///     2、给用授权，添加到数据库
    ///      PermissionManager 全局管理(客户端调用)
    ///      PermissionManagementProvider：自定义扩展：1、把权限存储到redis(扩展调用)
    ///      IPermissionGrantRepository 
    ///      如何扩展代码思路。
    ///        1、遍历执行集合
    ///        2、还可以使用加字段规则
    /// 3、鉴权
    ///     1、使用AOP获取特性权限
    ///     2、校验权限
    /// </summary>
    public class ProductAppService : CrudAppService<
                                    Products, 
                                    ProductDto, 
                                    Guid, 
                                    PagedAndSortedResultRequestDto,
                                    CreateProductDto, 
                                    UpdateProductDto>, IProductAppService
    {
        public IProductAbpRepository _productAbpRepository;

        public ProductAppService(IProductAbpRepository repository)
            : base(repository)
        {
            this._productAbpRepository = repository;
        }

        /*public override Task<ProductDto> CreateAsync(CreateProductDto input)
        {
            return base.CreateAsync(input);
        }*/



        //[RemoteService(IsEnabled = false)]
        public ProductDto GetProductByAttr(ProductAttrQueryDto createProductDto)
        {
            // 1、商品属性
            Products product = _productAbpRepository.GetProductByName(createProductDto.productName);

            // 2、转换成Dto(这样无法自动转换)
            ProductDto productDto = ObjectMapper.Map<Products,ProductDto>(product);
            return productDto;
        }

        /// <summary>
        /// 查询商品。同时查询图片
        /// </summary>
        /// <returns></returns>
        public List<ProductDto> GetProductAndImages()
        {
            // 1、查询所有和图片
            IEnumerable<Products> products = _productAbpRepository.GetProductAndImages();

            // 2、然后映射
            return ObjectMapper.Map<IEnumerable<Products>, List<ProductDto>>(products);
        }

        /// <summary>
        /// 汇总接口
        /// </summary>
        /// <returns></returns>
        public ProductTotaLDto GetProductTotals()
        {
            throw new NotImplementedException();
        }
    }
}
