using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using System.Data.Entity;

namespace OnlineShop.Dal.Classes
{
    /// <summary>
    /// Repository wrapping Category context
    /// </summary>
    public class OrderRepository : DbContextRepositoryBase<Order>, IOrderRepository
    {
        #region Constructor 

        public OrderRepository(IOnlineShopDbContext dbContext) : base((DbContext)dbContext)
        {
        }

        #endregion
    }
}
