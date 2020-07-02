using ConnexusCommon.Services.Base.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace OnlineShop.Services
{
    public class EmailService : IEmailService
    {
        private readonly ExceptionHelper _exceptionHelper;

        public EmailService(ExceptionHelper exceptionHelper)
        {
            _exceptionHelper = exceptionHelper;
        }

        public ExecResponse SendOrderConfirmationEmail(string customerEmail)
        {
            return _exceptionHelper.TryCatchWrap(
                errorCode: 1,
                code: () =>
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add(customerEmail);
                    mail.From = new MailAddress("techbyangelique@gmail.com");
                    mail.Subject = "Tech by Angelique Order Confirmation"; ;
                    mail.Body = "Your order is confirmed! "; // add more details TODO pass in table with order, possibly in HTML with images n stuff
                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("techbyangelique@gmail.com", "Fruit-2019");
                    //smtp.Send(mail);

                });
        }
    }
}
