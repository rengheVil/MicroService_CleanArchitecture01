using MicroservicesSolutionProject001.Database;
using Product.Core.Entities;
using Product.Core.IRepository;

namespace ProductInfrastucture.Repository
{
    internal class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        //
        public async Task<Product.Core.Entities.Product> AddProducts (Product.Core.Entities.Product product)
        {
            var AddProducts = await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();

            return AddProducts.Entity;
        }
            
    }
}
