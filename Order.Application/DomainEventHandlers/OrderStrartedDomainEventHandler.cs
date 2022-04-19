using MediatR;
using Order.Application.Repository;
using Order.Domain.AggregateModels.BuyersModels;
using Order.Domain.Events;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Order.Application.DomainEventHandlers
{
    public class OrderStrartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository _buyerRepository;

        public OrderStrartedDomainEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if(string.IsNullOrEmpty(notification.Order.Username))
            {
                var newBuyer = new Buyer(notification.BuyerUserName);
                // _buyerRepository.Add(newBuyer); // create buyer and get new id

                // set order's id
            }
        }
    }
}
