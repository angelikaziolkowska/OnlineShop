using OnlineShop.Dal.Models;

namespace OnlineShop.Dal.Interfaces
{
    /// <summary>
    /// Order repository interface; this is a facade on IDbContextRepositoryBase<Order>
    /// </summary>
    public interface IOrderRepository : IDbContextRepositoryBase<Order>
    {
    }
}
