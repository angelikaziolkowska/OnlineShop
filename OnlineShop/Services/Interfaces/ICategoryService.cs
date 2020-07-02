using System.Collections.Generic;
using ConnexusCommon.Services.Base.Classes;

namespace OnlineShop.Services
{
    public interface ICategoryService
    {
        ExecResponse<List<CategoryViewModel>> GetAllCategories();
    }
}