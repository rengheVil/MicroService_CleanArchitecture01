using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Core.DTO;
using Product.Core.IRepository;
using Product.Core.Entities;
using Product.Core.IServices;


namespace Product.Core.Services
{
    internal class ProductServices : IProductServices
    {


        private readonly IProductRepository _Prepository;

        public ProductServices(IProductRepository prepository)
        {
            _Prepository = prepository;
        }

        public async Task<ProductResponseDTO> AddProduct(ProductRequestDTO product)
        {
            var products = new Product.Core.Entities.Product
            {
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                Description = product.Description
            };

            var data = await _Prepository.AddProducts(products);
            var response = new ProductResponseDTO
            {
                Name = data.Name,
                Quantity = data.Quantity,
                Description = data.Description,

            };
            return response;
        }

        // delete product

        public async Task DeleteProduct(Guid Id)
        {
            await _Prepository.DeleteProducts(Id);
        }
    }
}
