using ConnexusCommon.Services.Base.Classes;
using OnlineShop.Dal;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class CartService : ICartService
    {
        private readonly ExceptionHelper _exceptionHelper;
        private readonly IOnlineShopDbContext _db;

        public CartService(ExceptionHelper exceptionHelper, IOnlineShopDbContext db)
        {
            _exceptionHelper = exceptionHelper;
            _db = db;
        }

        /// <summary>
        /// Add to cart or increase quantity if already in cart
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productId"></param>
        /// <param name="categoryId"></param>
        public ExecResponse AddOrUpdateCarts(string userId, int? productId, int? categoryId)
        {
            return _exceptionHelper.TryCatchWrap(
                    errorCode: 2,
                    code: () =>
                    {
                        var cart = _db.Carts.FirstOrDefault(m => m.ProductRefId == productId && m.UserId == userId);

                        // If this product already in cart then increase quantity in db
                        if (cart != null)
                        {
                            cart.Quantity++;
                        }
                        else // Add this product to cart for user
                        {
                            cart = new Cart() { ProductRefId = productId, Quantity = 1, UserId = userId};
                        }

                        _db.Carts.AddOrUpdate(cart);
                        _db.SaveChanges();
                    });
        }

        /// <summary>
        /// Remove item from cart or decrese it's quantity from cart if more than 1
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productId"></param>
        public ExecResponse RemoveFromCart(string userId, int productId)
        {
            return _exceptionHelper.TryCatchWrap(
                errorCode: 3,
                code: () =>
                {
                    var cart = _db.Carts.FirstOrDefault(m => m.ProductRefId == productId && m.UserId == userId);
                    if (cart.Quantity == 1)
                    {
                        _db.Carts.Remove(_db.Carts.FirstOrDefault(m => m.ProductRefId == productId && m.UserId == userId));
                    }
                    else
                    {
                        cart.Quantity--;
                        _db.Carts.AddOrUpdate(cart);
                    }

                    _db.SaveChanges();
                });
        }

        public List<Cart> GetCartResults(string userId)
        {
            var cartResults = _db.Carts.Include("Product").Where(x => x.UserId == userId).ToList();
            return cartResults;
        }

        /// <summary>
        /// Method to get number of items in the card
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int? GetCartCount(string userId)
        {
            if (_db.Carts.Where(x => x.UserId == userId).Any())
            {
                return _db.Carts.Where(x => x.UserId == userId).Sum(x => x.Quantity);
            }
            return null;
        }

        //public class CartViewModel
        //{
        //    /// <summary>
        //    /// System-generated identity column
        //    /// </summary>
        //    public int Id { get; set; }

        //    /// <summary>
        //    /// Id of the user from cookie
        //    /// </summary>
        //    public string UserId { get; set; }

        //    /// <summary>
        //    /// Quantity of the product in cart
        //    /// </summary>
        //    public int Quantity { get; set; }

        //    /// <summary>
        //    /// Foreign key for the customer
        //    /// </summary>     
        //    public int? ProductRefId { get; set; }

        //    /// <summary>
        //    /// Name of the product
        //    /// </summary>
        //    public string ProductName { get; set; }

        //    /// <summary>
        //    /// Price of the product
        //    /// </summary>
        //    public float ProductPrice { get; set; }

        //    public float LineTotal
        //    {
        //        get
        //        {
        //            return Quantity * ProductPrice;
        //        }
        //    }
        //}
    }
}
