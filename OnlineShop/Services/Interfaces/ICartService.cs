using System.Collections.Generic;
using ConnexusCommon.Services.Base.Classes;
using OnlineShop.Dal.Models;

namespace OnlineShop.Services
{
    public interface ICartService
    {
        ExecResponse AddOrUpdateCarts(string userId, int? productId, int? categoryId);
        int? GetCartCount(string userId);
        List<Cart> GetCartResults(string userId);
        ExecResponse RemoveFromCart(string userId, int productId);
    }
}