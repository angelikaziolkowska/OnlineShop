using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Dal.Models
{
    public class DirectDebit : PaymentMethod
    {
        /// <summary>
        /// Int value for the plan, (aka how many months is payment split into)
        /// </summary>
        public PayInMonths PayInMonths { get; set; }
    }

    public enum PayInMonths 
    { 
        Plan1 = 6, //6 months
        Plan2 = 12, //1 year
        Plan3 = 18, //1.5 years
        Plan4 = 24 //2 years
    }

}
