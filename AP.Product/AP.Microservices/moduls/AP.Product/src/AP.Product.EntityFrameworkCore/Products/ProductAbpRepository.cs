using AP.Product.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Linq;

namespace AP.Product.Products
{
    /// <summary>
    /// 商品仓储实现
    /// </summary>
    [Dependency(ServiceLifetime.Transient)]
    public class ProductAbpRepository : EfCoreRepository<ProductDbContext, Products, Guid>, IProductAbpRepository
    {
        public ProductAbpRepository(
            IDbContextProvider<ProductDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public override async Task<Products> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            DbSet<Products> products = await GetDbSetAsync();
            return products.Include(p => p.ProductImages).Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Products> GetProductAndImages()
        {
            DbSet<Products> products = GetDbSetAsync().Result;

            return products.Include(product => product.ProductImages).ToList();
        }

        /// <summary>
        /// 根据商品名称，查询商品
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public Products GetProductByName(string ProductName)
        {
            // 1、第一种实现
            //EBusinessDbContext eBusinessDbContext = GetDbContextAsync().Result;

            // 2、第二种实现，根据名称获取商品
            DbSet<Products>  products = GetDbSetAsync().Result;
            return products.Where(product => product.ProductTitle == ProductName).FirstOrDefault();
        }


    }
}
