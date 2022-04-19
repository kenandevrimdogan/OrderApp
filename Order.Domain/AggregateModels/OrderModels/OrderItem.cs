﻿using Order.Domain.SeedWork;
using System.Collections.Generic;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; private set; }

        public decimal Price { get; private set; }

        public int ProductId { get; private set; }

        public OrderItem(int quantity, decimal price, int productId)
        {
            Quantity = quantity;
            Price = price;
            ProductId = productId;
        }
    }
}