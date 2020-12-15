using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManagementService.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementService.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await FindAll()
                .Include(x => x.Addresses)
                .ToListAsync();
        }
    }
}
