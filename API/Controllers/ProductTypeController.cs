using API.Core.Abstract;
using API.Core.DbModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        //private IProductTypeRepository _iProductTypeRepository;
        private IGenericRepository<ProductType> _productTypeRepository;
        public ProductTypeController(IGenericRepository<ProductType> productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            var data = await _productTypeRepository.ListAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductTypeById(int id)
        {
            var data = await _productTypeRepository.GetByIdAsync(id);
            return Ok(data);
        }
    }
}

