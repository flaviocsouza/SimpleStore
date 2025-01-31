using SimpleStore.Application.Interfaces.Repositories;
using SimpleStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStore.Infra.DbConfiguration.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SimpleStoreDbContext context) : base(context) { }
    }
}
