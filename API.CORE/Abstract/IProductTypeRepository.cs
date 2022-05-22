using API.Core.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Abstract
{
    public interface IProductTypeRepository
    {
        /// <summary>
        /// ProductType by id veriable
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ProductType> GetProductTypeByIdAsync(int id);
        /// <summary>
        /// List of ProductsType
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
