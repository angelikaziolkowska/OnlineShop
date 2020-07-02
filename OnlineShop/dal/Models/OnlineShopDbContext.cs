using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OnlineShop.Dal
{
    /// <summary>
    /// Entity Framework DB Context for OnlineShop database
    /// </summary>
    public class OnlineShopDbContext : DbContext, IOnlineShopDbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }

        public OnlineShopDbContext() : base("name=OnlineShopDbContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
