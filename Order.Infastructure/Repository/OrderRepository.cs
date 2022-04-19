using Order.Application.Repository;
using System.Threading.Tasks;

namespace Order.Infastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> SaveCangesAsync()
        {
            return Task.FromResult(1);  
        }
    }
}
