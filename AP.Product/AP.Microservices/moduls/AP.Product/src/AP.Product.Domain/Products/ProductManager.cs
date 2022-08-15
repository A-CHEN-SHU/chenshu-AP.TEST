/*using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using RuanMou.Projects.ProductServices.Models;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;
using Volo.Abp.Localization;
using DependencyAttribute = Volo.Abp.DependencyInjection.DependencyAttribute;

namespace Acme.BookStore.Authors
{
    /// <summary>
    /// 商品领域服务
    /// </summary>
    [Dependency(ServiceLifetime.Transient)]
    public class ProductManager *//*: ITransientDependency*//*
    {
        private readonly IProductRepository _productRepository;
        public ILanguageProvider languageProvider { set; get; } // 获取所有语言

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// 1、规则1：商品名称不能重复
        /// 2、规则2：商品名称不能为空
        /// </summary>
        /// <param name="ProductTitle"></param>
        public void HasProductTitle(string ProductTitle)
        {
            Products products = _productRepository.GetProductByName(ProductTitle);
            if (products != null)
            {
                #region 1、默认异常信息
                {
                    //throw new Exception("商品名称不能重复");
                    *//*throw new Exception(_localizer["ProductException", ProductTitle]);*//*
                }
                #endregion

                #region 2、abp异常信息
                {
                    // ProductException
                   // throw new BusinessException(EBusinessDomainErrorCodes.ProductCreateErrorCode, _localizer["ProductException"]);
                   // throw new BusinessException(EBusinessDomainErrorCodes.ProductCreateErrorCode, "The product name must be unique");
                }
                #endregion

                #region 3、abp友好异常信息
                {
                  *//*  throw new UserFriendlyException("商品名称不能重复", EBusinessDomainErrorCodes.ProductCreateErrorCode,"商品名称["+ ProductTitle + " ]不能重复")
                                .WithData("productTitle", ProductTitle);*//*
                }
                #endregion


                #region 4、获取所有语言
                {
                    // 1、获取不同
                    var languages = languageProvider.GetLanguagesAsync().Result;
                    foreach (var language in languages)
                    {
                       // language.
                    }

                    // 2、语言显示到UI界面

                    // 3、根据语言显示具体信息
                    //  工具：
                    //   1、Cookie 目的：记录本地化信息
                    //   2、AbpLanguagesController 语言切换接口
                    //   3、LocalizationResourceContributorList 根据国家获取具体值
                }
                #endregion
            }
        }
    }
}
*/