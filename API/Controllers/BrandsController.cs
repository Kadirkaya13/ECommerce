using API.Core.Abstract;
using API.Core.DbModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        //private IBrandRepository _iBrandRepository;
        private IGenericRepository<Brand> _brandRepository;
        public BrandsController(IGenericRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Brand>>> GetBrands()
        {
            var data = await _brandRepository.ListAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrandById(int id)
        {


            var data = await _brandRepository.GetByIdAsync(id);
            return Ok(data);
        }
    }
}
