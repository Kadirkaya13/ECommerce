using API.Core.DbModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Core.Abstract;
using API.Infrastructure.Data;
using API.Dtos;
using AutoMapper;
using API.Core.Specifications;
using API.Helpers;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseApiController
    {
        //private StoreContext _context;
        //private IProductRepository _iProductRepository;
        private IGenericRepository<Product> _productRepository;
        private IMapper _mapper;
        public ProductsController(IGenericRepository<Product> productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<Pagination<ProductDto>>> GetProducts([FromQuery]ProductSpecParams productSpecParams)
        {
            var spec = new ProductsWithProductTypeAndBrandsSpecification(productSpecParams);

            var countSpec = new ProductsWithFiltersForCountSpecification(productSpecParams);

            var totalItems = await _productRepository.CountAsync(spec);

            var products = await _productRepository.ListWithSpecAsync(spec);

            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDto>>(products);

            return Ok(new Pagination<ProductDto>(productSpecParams.PageIndex, productSpecParams.PageSize, totalItems, data));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var spec = new ProductsWithProductTypeAndBrandsSpecification(id);

            var data = await _productRepository.GetEntityWithSpec(spec);

            return _mapper.Map<Product, ProductDto>(data);


        }
    }
}
