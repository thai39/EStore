using EStore.Model;
using EStore.pagination;
using EStore.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EStore.Controllers
{
    [Authorize]
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<product>>> ListProduct([FromQuery] PageParameter pageParameters)
        {
            return await _productService.GetListProduct(pageParameters);
        }

        [HttpGet("search")]
        public IActionResult Search(string value)
        {
            return Ok(_productService.SearchPro(value));
        }

        
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_productService.GetProduct(id));
        }

        
        [HttpPost("add")]
        public void Post([FromForm] product pro)
        {
            _productService.AddProduct(pro);
        }

        
        [HttpPut("edit/{id}")]
        public void Put(product pro)
        {
            _productService.UpdateProduct(pro);
        }

        
        [HttpDelete("del/{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
