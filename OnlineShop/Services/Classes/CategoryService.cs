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
    public class CategoryService : ICategoryService
    {
        private readonly ExceptionHelper _exceptionHelper;
        public static OnlineShopDbContext db = new OnlineShopDbContext();

        public CategoryService(ExceptionHelper exceptionHelper)
        {
            _exceptionHelper = exceptionHelper;
        }

        public ExecResponse<List<CategoryViewModel>> GetAllCategories()
        {
            return _exceptionHelper.TryCatchWrap(
                errorCode: 1,
                code: () =>
                {
                    return db.Categories.Select(x => new CategoryViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageName = "category" + x.Id,                      
                    }).ToList();
                });
        }
    }

    public class CategoryViewModel
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; }

        public string ImageName { get; set; }
    }
}
