using System.Data.Entity;
using OnlineShop.Dal.Models;

namespace OnlineShop.Dal
{
    public interface IOnlineShopDbContext
    {
        DbSet<Cart> Carts { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }

        int SaveChanges();
    }
}