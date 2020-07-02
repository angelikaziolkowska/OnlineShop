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
    public class Customer
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of customer and on card
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Billing Address and delivery address
        /// </summary>
        public string Address { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Billing and delivery postcode
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Name of customer and on card
        /// </summary>
        public string BillingName { get; set; }

        /// <summary>
        /// Billing Address and delivery address
        /// </summary>
        public string BillingAddress { get; set; }

        /// <summary>
        /// Billing and delivery postcode
        /// </summary>
        public string BillingPostcode { get; set; }
    }
}
