using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Core.IServices;

namespace MicroservicesSolutionProject001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        //[HttpGet]
        //[Route("Get-Product-over")]

        //public async Task<IActionResult> GetAbovePrice100()
        //{
        //    var items = await _Pservices.GetAbovePrice100();
        //    return Ok(items);
        //}

        //[HttpPost("Add-Product")]
        //public async Task<IActionResult> AddProduct(ProductRequestDTO productRequestDTO)
        //{
        //    var data = await _Pservices.AddProduct(productRequestDTO);
        //    return Ok(data);
        //}


        //[HttpDelete("Delete-Product")]
        //public async Task<IActionResult> DeleteProduct(Guid Id)
        //{
        //    await _Pservices.DeleteProduct(Id);
        //    return Ok("Product-Successfully-Deleted");
        //}


    }


}



