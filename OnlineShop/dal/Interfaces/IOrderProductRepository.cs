using OnlineShop.Dal.Models;

namespace OnlineShop.Dal.Interfaces
{
    /// <summary>
    /// Order Product repository interface; this is a facade on IDbContextRepositoryBase<OrderProduct>
    /// </summary>
    public interface IOrderProductRepository : IDbContextRepositoryBase<OrderProduct>
    {
    }
}
