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
    public class HomeController : Controller
    {

        //public static string userId = GetUserIdFromCookie();
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICartService _cartService;

        public HomeController(ICategoryService categoryService, IProductService productService, ICartService cartService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _cartService = cartService;
        }


        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult Category()
        {
            var categories = _categoryService.GetAllCategories();

            return View(categories.Value);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }       
    }
}