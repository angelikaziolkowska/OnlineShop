using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Dal.Models
{
    /// <summary>
    /// Categories
    /// </summary>
    public class Category
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public string ImageName { get; set; }

        /// <summary>
        /// List of products for this category
        /// </summary>
        public ICollection<Product> Products { get; protected set; } = new List<Product>();
    }
}
