using SimpleStore.Application.Interfaces.Repositories;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.Repositories
{
    public class SaleItemRepository : BaseRepository<SaleItem>, ISaleItemRepository
    {
        public SaleItemRepository(SimpleStoreDbContext context) : base(context)
        {
        }
    }


}
