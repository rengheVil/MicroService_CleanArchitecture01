using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Core.IServices;
using Product.Core.DTO;

namespace ProductWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _services;

        public ProductController(IProductServices services)
        {
            _services = services;
        }

        // add product
        [HttpPost("Add-Product")]
        public async Task<IActionResult> AddProduct(ProductRequestDTO productRequest)
        {
            var data = await _services.AddProduct(productRequest);
            return Ok(data);
        }

        // delete product
        [HttpDelete("Delete-Product/{Id}")]
        public async Task<IActionResult> DeleteProduct(Guid Id)
        {
            await _services.DeleteProduct(Id);
            return Ok();
        }
    }
}
