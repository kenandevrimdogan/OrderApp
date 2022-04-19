using Order.Application.Repository;
using System.Threading.Tasks;

namespace Order.Infastructure.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        public Task<int> SaveCangesAsync()
        {
            return Task.FromResult(1);  
        }
    }
}
