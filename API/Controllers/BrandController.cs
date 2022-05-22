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
    public class BrandController : ControllerBase
    {
        private IBrandRepository _iBrandRepository;
        public BrandController(IBrandRepository iBrandRepository)
        {
            _iBrandRepository = iBrandRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Brand>>> GetBrands()
        {
            var data = await _iBrandRepository.GetBrandsAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrandById(int id)
        {


            var data = await _iBrandRepository.GetBrandByIdAsync(id);
            return Ok(data);
        }
    }
}
