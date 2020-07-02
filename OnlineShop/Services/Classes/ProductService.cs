using ConnexusCommon.Services.Base.Classes;
using OnlineShop.Dal;
using OnlineShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class ProductService : IProductService
    {
        private readonly ExceptionHelper _exceptionHelper;
        public static OnlineShopDbContext db = new OnlineShopDbContext();

        public ProductService(ExceptionHelper exceptionHelper)
        {
            _exceptionHelper = exceptionHelper;
        }

        public ExecResponse<List<ProductViewModel>> GetAllProducts(int categoryId)
        {
            return _exceptionHelper.TryCatchWrap(
                errorCode: 1,
                code: () =>
                {
                    var products = db.Products.Include("Category").Where(m => m.CategoryRefId == categoryId).ToList();

                    return products.Select(x => new ProductViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        CategoryRefId = categoryId,
                        CategoryName = x.Category.Name,
                        ImageName = "product" + x.Id,
                    }).ToList();
                });
        }
    }

    public class ProductViewModel
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id for category
        /// </summary>
        public int CategoryRefId { get; set; }

        public string CategoryName { get; set; }

        public string ImageName { get; set; }
    }
}
