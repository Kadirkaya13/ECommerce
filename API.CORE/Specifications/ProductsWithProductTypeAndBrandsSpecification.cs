using API.Core.DbModel;
using API.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Data
{
    public class ProductsWithProductTypeAndBrandsSpecification:BaseSpecification<Product>
    {
        public ProductsWithProductTypeAndBrandsSpecification()
        {
            AddInclude(x => x.Brand);
            AddInclude(x => x.ProductType);
        }
        public ProductsWithProductTypeAndBrandsSpecification(int id)
            :base(x=>x.Id==id)
        {
            AddInclude(x => x.Brand);
            AddInclude(x => x.ProductType);
        }
    }
}
