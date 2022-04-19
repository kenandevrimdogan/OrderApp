using MediatR;
using System;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent: INotification
    {
        public string BuyerUserName { get; set; }

        public AggregateModels.OrderModels.Order Order { get; set; }

        public OrderStartedDomainEvent(string buyerUserName, AggregateModels.OrderModels.Order order)
        {
            BuyerUserName = buyerUserName ?? throw new ArgumentNullException(nameof(buyerUserName));
            Order = order ?? throw new ArgumentNullException(nameof(order));
        }
    }
}
