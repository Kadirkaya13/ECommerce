using API.Core.Abstract;
using API.Core.DbModel;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infrastructure.Concrete
{
    public class BrandRepository : IBrandRepository
    {
        private readonly StoreContext _context;
        public BrandRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            return await _context.Brands.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<Brand>> GetBrandsAsync()
        {
            return await _context.Brands.ToListAsync();
        }
    }
}
