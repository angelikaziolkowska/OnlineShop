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
    public class OrderProduct
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The quantity of the product for the order
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Foreign key for the order
        /// </summary>
        [ForeignKey("Order")]
        public int OrderRefId { get; set; }
        public Order Order { get; set; }

        /// <summary>
        /// Foreign key for the order
        /// </summary>
        [ForeignKey("Product")]
        public int ProductRefId { get; set; }
        public Product Product { get; set; }
    }
}
