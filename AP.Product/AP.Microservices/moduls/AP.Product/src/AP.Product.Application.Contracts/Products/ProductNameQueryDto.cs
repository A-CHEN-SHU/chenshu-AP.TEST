using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AP.Product.Products
{
    class ProductNameQueryDto : PagedAndSortedResultRequestDto
    {
        public string ProductName { set; get; }
    }
}
