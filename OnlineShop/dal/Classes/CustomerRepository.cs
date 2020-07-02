using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using ConnexusComponents.Data.Base;
using System.Data.Entity;

namespace OnlineShop.Dal.Classes
{
    /// <summary>
    /// Repository wrapping Caustomer context
    /// </summary>
    public class CustomerRepository : DbContextRepositoryBase<Customer>, ICustomerRepository
    {
        #region Constructor 

        public CustomerRepository(IOnlineShopDbContext dbContext) : base((DbContext)dbContext)
        {
        }

        #endregion
    }
}
