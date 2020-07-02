using OnlineShop.Dal;
using OnlineShop.Dal.Models;
using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {

        //public static string userId = GetUserIdFromCookie();
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICartService _cartService;

        public ProductController(ICategoryService categoryService, IProductService productService, ICartService cartService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _cartService = cartService;
        }

        public ActionResult Shop(int categoryId)
        {
            var products = _productService.GetAllProducts(categoryId);

            return View(products.Value);
        }

        [HttpGet]
        public PartialViewResult _OpenPopup()
        {
            return PartialView();
        }
    }
}