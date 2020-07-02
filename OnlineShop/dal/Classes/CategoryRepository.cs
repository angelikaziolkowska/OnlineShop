using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using System.Data.Entity;

namespace OnlineShop.Dal.Classes
{
    /// <summary>
    /// Repository wrapping Category context
    /// </summary>
    public class CategoryRepository : DbContextRepositoryBase<Category>, ICategoryRepository
    {
        #region Constructor 

        public CategoryRepository(IOnlineShopDbContext dbContext) : base((DbContext)dbContext)
        {
        }

        #endregion
    }
}
