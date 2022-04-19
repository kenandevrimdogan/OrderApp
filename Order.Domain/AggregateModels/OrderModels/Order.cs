using MediatR;
using Order.Domain.Events;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }

        public string Description { get; private set; }

        public string Username { get; private set; }

        public string OrderStatus { get; private set; }

        public Address Address { get; private set; }

        public ICollection<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, string userName, string orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if(orderDate < DateTime.Now)
            {
                throw new Exception("Order date must be greater than now");
            }

            if (string.IsNullOrEmpty(Address.City))
            {
                throw new Exception("Order Address not be empty");
            }

            OrderDate = orderDate;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Username = userName;
            OrderStatus = orderStatus ?? throw new ArgumentNullException(nameof(orderStatus));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            OrderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));

            AddDomainEvents(new OrderStartedDomainEvent(userName, this));
        }

        public void AddOrderItem(int quantity, decimal price, int productId)
        {
            OrderItem orderItem = new(quantity, price, productId);

            OrderItems.Add(orderItem);
        }
    }
}
