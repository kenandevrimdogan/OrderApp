using Order.Domain.SeedWork;
using System.Collections.Generic;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Address : ValueObject
    {
        public string Country { get; set; }

        public string City { get; set; }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Country;
            yield return City;
        }
    }
}
