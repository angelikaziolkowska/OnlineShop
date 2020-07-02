using OnlineShop.Dal.Models;

namespace OnlineShop.Dal.Interfaces
{
    /// <summary>
    /// Product repository interface; this is a facade on IDbContextRepositoryBase<Product>
    /// </summary>
    public interface IProductRepository : IDbContextRepositoryBase<Product>
    {
    }
}
