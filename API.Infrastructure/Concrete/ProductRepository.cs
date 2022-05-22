using API.Core.Abstract;
using API.Core.DbModel;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .Include(x=>x.Brand)
                .Include(x=>x.ProductType)
                .Where(x => x.Id == id).FirstOrDefaultAsync(); 
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
                .Include(x => x.Brand)
                .Include(x => x.ProductType)
                .ToListAsync();
        }
    }
}
