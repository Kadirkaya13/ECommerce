using API.Infrastructure.DataContext;
using API.Core.DbModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Core.Abstract;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private StoreContext _context;
        private IProductRepository _iProductRepository;
        public ProductsController(IProductRepository iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _iProductRepository.GetProductsAsync() ;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {


            var data = await _iProductRepository.GetProductByIdAsync(id);
            return Ok(data);
        }
    }
}
