namespace Product.Core.IRepository
{
    public interface IProductRepository
    {
        Task<Product.Core.Entities.Product> AddProducts(Product.Core.Entities.Product product);
    }
}

