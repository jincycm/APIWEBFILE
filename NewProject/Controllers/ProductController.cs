using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductProject.Models.Dtos;
using ProductProject.Services.Interface;

namespace ProductProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProductDetails")]
        public async Task<IActionResult> GetProducts()
        {
            var response = _productService.GetProductsDetails();
            return Ok(response);
        }

        [HttpPost("CreateStudentDetails")]
        public async Task<IActionResult> CreateProductData(ProductDto productDto)
        {
            var response = _productService.CreateProductData(productDto);
            return Ok(response);
        }


        [HttpPut("UpdateStudent/{Id}")]
        public async Task<IActionResult> UpdateProductData(int Id, ProductDto productDto)
        {
            var response = _productService.UpdateProductData(Id, productDto);
            return Ok(response);
        }

        [HttpDelete("DeleteStudent/{Id}")]
        public async Task<IActionResult> DeleteProductData(int Id)
        {
            var response = _productService.DeleteProductData(Id);
            return Ok(response);
        }

    }
}
