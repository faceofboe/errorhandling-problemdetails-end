
using errorhandling_problemdetails.Repository.Data.Models;
using errorhandling_problemdetails.Services.Interfaces;
using errorhandling_problemdetails.Custom_Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace errorhandling_problemdetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get() => await _productService.GetAllPrpoducts();

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _productService.GetProductById(id);
            if (product != null)
                return product;
            else throw new ProductNotFoundException(Request.Path.Value);
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Product>> GetByName(string name)
        {
            var product = await _productService.GetProductByName(name);
            if (product == null)
                throw new Exception("There was an exception while fetching the product");
            return product;
                
        }

        [HttpPost]
        public async Task Post([FromBody] Product product) => await _productService.CreateNewProduct(product);
    }
}
