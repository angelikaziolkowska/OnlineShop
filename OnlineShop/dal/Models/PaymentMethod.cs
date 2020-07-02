using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Dal.Models
{
    public class PaymentMethod
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Id of the user from cookie
        /// </summary>
        [MaxLength(32)]
        public string UserId { get; set; }

        /// <summary>
        /// Delivery and billing personal details
        /// </summary>
        public Customer CustomerDetails { get; set; }
    }
}
