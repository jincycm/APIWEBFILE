using ProductProject.Models.Dtos;
using ProductProject.Models.Entity;

namespace ProductProject.Services.Interface
{
    public interface IProductService 
    {
        public IQueryable<Product> GetProductsDetails();
        public Task<ResponseDto> CreateProductData(ProductDto productDto);
        public Task<ResponseDto> UpdateProductData(int Id,ProductDto productDto);
        public Task<ResponseDto> DeleteProductData(int Id);
        
    }
}
