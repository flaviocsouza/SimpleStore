using SimpleStore.Application.Interfaces.Repositories;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.Repositories
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(SimpleStoreDbContext context) : base(context)
        {
        }
    }


}
