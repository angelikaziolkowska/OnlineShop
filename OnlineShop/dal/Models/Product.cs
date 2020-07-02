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
    public class Product
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Image of the product
        /// </summary>
        //public string ProductImg { get; set; }

        /// <summary>
        /// Foreign key for category
        /// </summary>
        [ForeignKey("Category")]
        public int CategoryRefId { get; set; }
        public Category Category { get; set; }

        public string ImageName { get; set; }

        /// <summary>
        /// List of carts this product
        /// </summary>
        public ICollection<Cart> Carts { get; protected set; } = new List<Cart>();
    }
}
