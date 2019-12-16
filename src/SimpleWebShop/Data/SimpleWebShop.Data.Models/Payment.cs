using System;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Payment : BaseModel<string>
    {
        public string PaymentType { get; set; }

        public bool Paid { get; set; }

        public bool Allowed { get; set; }
    }
}