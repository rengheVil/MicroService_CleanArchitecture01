using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.DTO
{
    public class ProductResponseDTO
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
    }
}

