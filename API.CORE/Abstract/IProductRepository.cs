using API.Core.DbModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Core.Abstract
{
    public interface IProductRepository
    {
        /// <summary>
        /// Product by id veriable
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProductByIdAsync(int id);
        /// <summary>
        /// List of Products
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
