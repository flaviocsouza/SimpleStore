using SimpleStore.Application.Interfaces.Repositories;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.Repositories
{
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(SimpleStoreDbContext context) : base(context)
        {
        }
    }


}
