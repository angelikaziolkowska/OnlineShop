using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using ConnexusComponents.Data.Base;
using System.Data.Entity;

namespace OnlineShop.Dal.Classes
{
    /// <summary>
    /// Repository wrapping Category context
    /// </summary>
    public class OrderProductRepository : DbContextRepositoryBase<OrderProduct>, IOrderProductRepository
    {
        #region Constructor 

        public OrderProductRepository(IOnlineShopDbContext dbContext) : base((DbContext)dbContext)
        {
        }

        #endregion
    }
}
