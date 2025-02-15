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
              //  Id = data.Id,
                Name = data.Name,
                //Price = data.Price,
                //Quantity = data.Quantity,
            };

            return response;
        }

        //public async Task<List<ProductResponseDTO>> GetAbovePrice100()
        //{
        //    var items = await _Prepository.GetAbovePrice100();
        //    var listOfProducts = new List<ProductResponseDTO>();

        //    foreach (var data in items)
        //    {
        //        var productObj = new ProductResponseDTO();
        //        productObj.Id = data.Id;
        //        productObj.Name = data.Name;
        //        productObj.Price = data.Price;
        //        productObj.Quantity = data.Quantity;

        //        listOfProducts.Add(productObj);

        //    }
        //    return listOfProducts;
        //}

        //public async Task<ProductResponseDTO> AddProduct(ProductRequestDTO productRequest)
        //{
        //    var addproduct = new Product();
        //    addproduct.Price = productRequest.Price;
        //    addproduct.Quantity = productRequest.Quantity;
        //    addproduct.Name = productRequest.Name;

        //    var data = await _Prepository.AddProduct(addproduct);

        //    var productResponse = new ProductResponseDTO();
        //    productResponse.Id = data.Id;
        //    productResponse.Name = data.Name;
        //    productResponse.Price = data.Price;
        //    productResponse.Quantity = data.Quantity;

        //    return productResponse;

        //}

        //public async Task DeleteProduct(Guid Id)
        //{
        //    await _Prepository.DeleteProduct(Id);

        //}



    }
}
