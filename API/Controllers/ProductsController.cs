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
using API.Infrastructure.Data;
using API.Dtos;
using AutoMapper;

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
        public async Task<ActionResult<IReadOnlyList<ProductDto>>> GetProducts()
        {
            var spec = new ProductsWithProductTypeAndBrandsSpecification();

            var data = await _productRepository.ListWithSpecAsync(spec);

            //return data.Select(p => new ProductDto
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Price = p.Price,
            //    Description = p.Description,
            //    Brand = p.Brand != null ? p.Brand.Name : string.Empty,
            //    ProductType = p.ProductType != null ? p.ProductType.Name : string.Empty,
            //    PictureUrl = p.PictureUrl
            //}).ToList();

            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDto>>(data));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var spec = new ProductsWithProductTypeAndBrandsSpecification(id);

            var data = await _productRepository.GetEntityWithSpec(spec);

            //return new ProductDto 
            //{
            //    Id= data.Id,
            //    Name = data.Name,
            //    Price = data.Price,
            //    Description = data.Description,
            //    Brand = data.Brand != null ? data.Brand.Name : string.Empty,
            //    ProductType = data.ProductType!=null ? data.ProductType.Name : string.Empty ,
            //    PictureUrl = data.PictureUrl
            //};
            return _mapper.Map<Product, ProductDto>(data);


        }
    }
}
