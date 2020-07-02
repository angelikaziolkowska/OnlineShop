using OnlineShop.Dal;
using OnlineShop.Dal.Models;
using OnlineShop.Helpers;
using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CheckoutController : Controller
    {

        //public static string userId = GetUserIdFromCookie();
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly IEmailService _emailService;
        private readonly ICartHelper _cartHelper;

        public CheckoutController(ICategoryService categoryService, IProductService productService, ICartService cartService, IEmailService emailService, ICartHelper cartHelper)
        {
            _categoryService = categoryService;
            _productService = productService;
            _cartService = cartService;
            _emailService = emailService;
            _cartHelper = cartHelper;
        }


        public ActionResult Checkout()
        {
            ViewBag.Message = "Checkout.";
            CartViewModel cartViewModel = _cartHelper.GetCartViewModel();

            return View("Checkout", cartViewModel);
        }

        [HttpGet]
        public PartialViewResult _Installments()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult _Card()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Checkout(long cardNumber, int cardType, int expiryMonth, int expiryYear, int cVV2Code, string name, string address, string postcode, string emailAddress, string billingName, string billingAddress, string billingPostcode)
        {
            //also must make sure there is validation such as attributes in models
            Card card = new Card
            {
                CardDetails = new CardDetails
                {
                    CardNumber = cardNumber,
                    CardType = cardType,
                    ExpiryMonth = expiryMonth,
                    ExpiryYear = expiryYear,
                    CVV2Code = cVV2Code
                },
                CustomerDetails = new Customer
                {
                    Name = name,
                    Address = address,
                    Postcode = postcode,
                    EmailAddress = emailAddress,
                    BillingName = billingName,
                    BillingAddress = billingAddress,
                    BillingPostcode = billingPostcode                   
                }
            };

            //save order to db

            // send order confirmation email
            var emailSent = _emailService.SendOrderConfirmationEmail(emailAddress);

            // if successful order was made
            if (emailSent.Success)
            {
                return View("Success", card);
            }
            return View("PaymentNotAccepted");

        }

        public ActionResult Order(Card card)
        {
            //add order to database

            //delete those items from cart


            //return order successful 
            return View();
        }

        [HttpGet]
        public PartialViewResult _Paypal()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult _Paypal(string login, string password)
        {

            return PartialView();
        }
    }
}