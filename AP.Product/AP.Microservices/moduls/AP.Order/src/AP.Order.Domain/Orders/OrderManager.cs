/*using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;
using DependencyAttribute = Volo.Abp.DependencyInjection.DependencyAttribute;

namespace Acme.BookStore.Authors
{
    /// <summary>
    /// 订单领域服务
    /// </summary>
    [Dependency(ServiceLifetime.Transient)]
    public class OrderManager : ITransientDependency
    {
        private readonly IProductRepository _productRepository;

        public OrderManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async void CreateAsync(string ProductTitle)
        {
            *//*IEnumerable<Product> products = _productRepository.GetProductByName(ProductTitle);
            if (products != null)
            {
                throw new Exception("商品名称不能重复");
            }*//*
        }

       
    }
}
*/