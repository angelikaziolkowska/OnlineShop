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
    public class Order
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// List of products for this order
        /// </summary>
        public ICollection<OrderProduct> OrderProducts { get; protected set; } = new List<OrderProduct>();

        /// <summary>
        /// The datetime  of when the order was made
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// If card was used is true 
        /// </summary>
        [Required]
        public bool CardTrue { get; set; }

        /// <summary>
        /// Foreign key for the customer
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerRefId { get; set; }
        public Customer Customer { get; set; }
    }
}
