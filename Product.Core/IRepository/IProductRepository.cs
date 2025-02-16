namespace Product.Core.IRepository
{
    public interface IProductRepository
    {
        // add product 
        Task<Product.Core.Entities.Product> AddProducts(Product.Core.Entities.Product product);

        // Delete
        Task DeleteProducts(Guid Id);

    }
}

