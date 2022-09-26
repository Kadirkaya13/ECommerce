﻿using API.Core.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Specifications
{
    public class ProductsWithFiltersForCountSpecification:BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecification(ProductSpecParams productSpecParams)
            : base(x =>
             (!productSpecParams.BrandId.HasValue || x.BrandId == productSpecParams.BrandId)
             &&
             (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId))
        {

        }
    }
}