using ConnexusComponents.Data.Interfaces;

namespace OnlineShop.Dal.Interfaces
{
    public interface IDbContextRepositoryBase<T> : IRepository<T> where T : class
    {
        int Save();
    }
}
