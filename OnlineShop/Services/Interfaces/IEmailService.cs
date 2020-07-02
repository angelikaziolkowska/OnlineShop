using ConnexusCommon.Services.Base.Classes;

namespace OnlineShop.Services
{
    public interface IEmailService
    {
        ExecResponse SendOrderConfirmationEmail(string customerEmail);
    }
}