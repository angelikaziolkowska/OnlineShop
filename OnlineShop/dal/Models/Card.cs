using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Dal.Models
{
    public class Card : PaymentMethod
    {
        public CardDetails CardDetails { get; set; }           
    }

    public enum CardType
    {
        Debit = 0,
        Credit = 1,
        Charge = 2,
        Prepaid = 3
    }
}
