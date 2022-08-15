using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AP.Product.Products
{
    /// <summary>
    /// 商品仓储
    /// 1、做定制化
    /// </summary>
    public interface IProductAbpRepository : IRepository<Products, Guid>
    {
        Products GetProductByName(string ProductName);

        /// <summary>
        /// 查询和图片
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Products> GetProductAndImages();
    }
}
