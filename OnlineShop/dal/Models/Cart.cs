using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Dal.Models
{
    /// <summary>
    /// Categories
    /// </summary>
    public class Cart
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
        /// Quantity of the product in cart
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Foreign key for the customer
        /// </summary>
        [ForeignKey("Product")]
        public int? ProductRefId { get; set; }
        public Product Product { get; set; }
        public int? Installments { get; set; }
        public string ImageName { get; set; }
    }
}
