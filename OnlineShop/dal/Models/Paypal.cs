using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Dal.Models
{
    public class Paypal : PaymentMethod
    {
        [Display(Name = "Paypal email address")]
        [EmailAddress(ErrorMessage = "The email is not valid.")]
        [Required(ErrorMessage = "The email address is required")]
        public string Login  { get; set; }

        public string Password { get; set; }
    }
}
