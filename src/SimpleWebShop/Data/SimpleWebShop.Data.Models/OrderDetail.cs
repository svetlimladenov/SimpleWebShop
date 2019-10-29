﻿namespace SimpleWebShop.Data.Models
{
    public class OrderDetail
    {
        public string OrderId { get; set; }

        public Order Order { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
