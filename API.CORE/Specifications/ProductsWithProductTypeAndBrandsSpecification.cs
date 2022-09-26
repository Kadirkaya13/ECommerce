using API.Core.DbModel;

namespace API.Core.Specifications
{
    public class ProductsWithProductTypeAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithProductTypeAndBrandsSpecification(ProductSpecParams productSpecParams)
            : base(x =>
             (!productSpecParams.BrandId.HasValue || x.BrandId == productSpecParams.BrandId)
             &&
             (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId))
        {
            AddInclude(x => x.Brand);
            AddInclude(x => x.ProductType);
            //AddOrderBy(x=>x.Name);

            ApplyPaging(productSpecParams.PageSize * (productSpecParams.PageIndex - 1), productSpecParams.PageSize);

            if (!string.IsNullOrWhiteSpace(productSpecParams.Sort))
            {
                switch (productSpecParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    case "nameDesc":
                        AddOrderByDescending(p => p.Name);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
        }
        public ProductsWithProductTypeAndBrandsSpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.Brand);
            AddInclude(x => x.ProductType);
        }
    }
}
