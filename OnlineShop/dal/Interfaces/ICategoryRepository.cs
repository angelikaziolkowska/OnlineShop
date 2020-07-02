using OnlineShop.Dal.Models;

namespace OnlineShop.Dal.Interfaces
{
    /// <summary>
    /// Category repository interface; this is a facade on IDbContextRepositoryBase<Category>
    /// </summary>
    public interface ICategoryRepository : IDbContextRepositoryBase<Category>
    {
    }
}
