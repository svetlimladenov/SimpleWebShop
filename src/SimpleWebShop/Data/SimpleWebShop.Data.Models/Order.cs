using System;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Order : BaseModel<string>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string OrderNumber { get; set; }

        public decimal TotalOrderPrice { get; set; }

        public string PaymentId { get; set; }

        public virtual Payment Payment { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public string ShipperId { get; set; }

        public virtual Shipper Shipper { get; set; }

        public bool Fulfilled { get; set; }
    }
}
