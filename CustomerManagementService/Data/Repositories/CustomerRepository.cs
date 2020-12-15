using System.Collections.Generic;
using System.Linq;
using CustomerManagementService.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementService.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customerEntities = _context.Customers
                .Include(x => x.Addresses)
                .AsNoTracking()
                .ToList();
            
            return customerEntities;
        }
    }
}
