using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using System.Data.Entity;

namespace OnlineShop.Dal.Classes
{
    /// <summary>
    /// Repository wrapping Product context
    /// </summary>
    public class ProductRepository : DbContextRepositoryBase<Product>, IProductRepository
    {
        #region Constructor 

        public ProductRepository(IOnlineShopDbContext dbContext) : base((DbContext)dbContext)
        {
        }

        #endregion
    }
}
