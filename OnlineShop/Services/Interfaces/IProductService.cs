using System.Collections.Generic;
using ConnexusCommon.Services.Base.Classes;

namespace OnlineShop.Services
{
    public interface IProductService
    {
        ExecResponse<List<ProductViewModel>> GetAllProducts(int categoryId);
    }
}