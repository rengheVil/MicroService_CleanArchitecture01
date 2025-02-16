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

        // add product
        public async Task<Product.Core.Entities.Product> AddProducts(Product.Core.Entities.Product product)
        {
            var AddProducts = await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();

            return AddProducts.Entity;
        }

        // delete product
        public async Task DeleteProducts(Guid Id)
        {
            var item = await _context.products.FindAsync(Id);
            _context.products.Remove(item);
            _context.SaveChangesAsync();
        }
    }
}
