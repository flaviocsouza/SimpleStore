using SimpleStore.Application.Interfaces.Repositories;
using SimpleStore.Domain.Models;

namespace SimpleStore.Infra.DbConfiguration.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(SimpleStoreDbContext context) : base(context)
        {
        }
    }


}
