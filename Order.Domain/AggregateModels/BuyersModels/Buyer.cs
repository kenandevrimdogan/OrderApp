using Order.Domain.SeedWork;
using System;

namespace Order.Domain.AggregateModels.BuyersModels
{
    public class Buyer : BaseEntity
    {
        public string UserName { get; set; }

        public Buyer(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
