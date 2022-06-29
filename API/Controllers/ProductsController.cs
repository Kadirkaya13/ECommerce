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
        //private IProductRepository _iProductRepository;
        private IGenericRepository<Product> _productRepository;
        public ProductsController(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.ListAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {


            var data = await _productRepository.GetByIdAsync(id);
            return Ok(data);
        }
    }
}
