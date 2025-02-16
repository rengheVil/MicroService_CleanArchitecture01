using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Core.DTO;
using Product.Core.Services;

namespace Product.Core.IServices
{
    public interface IProductServices
    {
        Task<ProductResponseDTO> AddProduct(ProductRequestDTO product);

        // Delete Product
        Task DeleteProduct(Guid Id);

    }
}
