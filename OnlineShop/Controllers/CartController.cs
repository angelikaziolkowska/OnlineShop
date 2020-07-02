using OnlineShop.Dal;
using OnlineShop.Dal.Models;
using OnlineShop.Helpers;
using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {

        //public static string userId = GetUserIdFromCookie();
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly ICartHelper _cartHelper;

        public CartController(ICategoryService categoryService, ICartService cartService, IProductService productService, ICartHelper cartHelper)
        {
            _categoryService = categoryService;
            _cartService = cartService;
            _productService = productService;
            _cartHelper = cartHelper;

        }

        public ActionResult AddToCart(int? productId, int? categoryId)
        {
            var userId = CookieHelper.GetUserIdFromCookie();

            // Add to cart or increase quantity
            _cartService.AddOrUpdateCarts(userId, productId, categoryId);
            
            // Depending on what page you're coming from return to that same page
            if(categoryId == null)
            {
                return RedirectToAction(nameof(Cart), "Cart");
            }
            return RedirectToAction("Shop", "Product", new { categoryId });
        }

        public ActionResult DeleteFromCart(int productId)
        {
            var userId = CookieHelper.GetUserIdFromCookie();

            // Remove from cart or reduce the quantity
            _cartService.RemoveFromCart(userId, productId);
            
            // Redirect back to the same page: Cart
            return RedirectToAction(nameof(Cart), "Cart");
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Your cart.";
            
            return View(_cartHelper.GetCartViewModel());
        }

        [HttpPost]
        public ActionResult Cart(int? installments)
        {
            Session["installments"] = installments;

            ViewBag.Message = "Checkout.";

            // Redirect to checkout controller method
            return RedirectToAction("Checkout", "Checkout" );
        }

        public ActionResult _CartCount()
        {
            var userId = CookieHelper.GetUserIdFromCookie();
            int? count = _cartService.GetCartCount(userId);

            return PartialView(count);
        }
    }
}