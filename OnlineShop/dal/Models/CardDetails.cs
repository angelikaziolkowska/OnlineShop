using System;

namespace OnlineShop.Dal.Models
{
    public class CardDetails
    {
        /// <summary>
        /// The long card number
        /// </summary>
        public long CardNumber { get; set; }

        /// <summary>
        /// The type of the card
        /// </summary>
        public int? CardType { get; set; }

        // make just in future
        public int ExpiryMonth { get; set; }

        public int ExpiryYear { get; set; }

        /// <summary>
        /// 3 number code on the back of the card
        /// </summary>
        public int CVV2Code { get; set; }
    }
}