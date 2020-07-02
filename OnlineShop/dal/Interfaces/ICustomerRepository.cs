using OnlineShop.Dal.Models;

namespace OnlineShop.Dal.Interfaces
{
    /// <summary>
    /// Customer repository interface; this is a facade on IDbContextRepositoryBase<Customer>
    /// </summary>
    public interface ICustomerRepository : IDbContextRepositoryBase<Customer>
    {
    }
}
